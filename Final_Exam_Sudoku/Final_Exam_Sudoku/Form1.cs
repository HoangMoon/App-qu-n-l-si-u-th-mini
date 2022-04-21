using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam_Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            createCells();

            startNewGame();
        }
        

        SudokuCell[,] cells = new SudokuCell[9, 9];

        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Tạo 81 ô cho bảng với style và vị trí dựa trên tọa độ
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Gán sự kiện nhấn phím cho mỗi ô
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // khóa ô(ko cho phép tương tác vs ô)
            if (cell.IsLocked)
                return;

            int value;

            // Thêm giá trị khi giá trị nút là number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Xóa giá trị ô khi giá trị là 0
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }
        private void startNewGame()
        {
            loadValues();

            var hintsCount = 0;

            // Gán số gợi ý dựa trên lever 
            if (SEZ.Checked)
                hintsCount = 60;
            else if (EZ.Checked)
                hintsCount = 45;
            else if (NM.Checked)
                hintsCount = 30;
            else if (H.Checked)
                hintsCount = 15;

            showRandomValuesHints(hintsCount);
        }
        
        private void showRandomValuesHints(int hintsCount)
        {
            // Show  random giá trị ô 
            // Số ô hiển thị phụ thuộc vào cấp độ của phần chơi 
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                // Style của hint khác vs giá trị nhập 
                //  khóa giá trị ô dc hiển thị người chơi ko dc sửa  
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }

        private void loadValues()
        {
            // Xóa giá trị từng ô
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            // Phương thức này sẽ được gọi đệ quy cho đến khi nó tìm thấy các giá trị phù hợp cho từng ô
            findValueForNextCell(0, -1);
        }
        Random random = new Random();

        private bool findValueForNextCell(int i, int j)
        {
            // Tăng giá trị cho i và j để chuyển sang ô tiếp theo và nếu đến cột cuối chuyển sang hàng tiếp theo
           
            if (++j > 8)
            {
                j = 0;

                // Thoát khi hết dòng
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Tìm một số ngẫu nhiên và hợp lệ cho ô và chuyển đến ô tiếp theo và kiểm tra xem nó có thể được phân bổ bằng một số ngẫu nhiên và hợp lệ khác không
            do
            {
                // Nếu không còn số nào trong danh sách để thử tiếp theo, hãy quay lại ô trước đó và phân bổ nó bằng một số khác
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Lấy một số ngẫu nhiên từ các số còn lại trong danh sách
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Xóa giá trị được phân bổ khỏi danh sách
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            // Testing line 
         cells[i, j].Text = value.ToString();

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {

                // Kiểm tra tất cả các ô theo hướng dọc
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Kiểm tra tất cả các ô theo hướng ngang
                if (i != x && cells[i, y].Value == value)
                    return false;
            }


            // Kiểm tra tất cả các ô trong khối cụ thể
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();

            // Tìm tất cả ô bị sai
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // Kiểm tra nếu nhập đúng thỏa mãn đk thì thắng 
            if (wrongCells.Any())
            {
                // Highlight lỗi sai
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong inputs");
            }
            else
            {
                MessageBox.Show("You Wins");
            }
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                //Xóa toàn bộ những gì đã nhập
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
    }
}
