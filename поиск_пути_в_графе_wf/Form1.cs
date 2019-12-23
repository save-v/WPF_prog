using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace поиск_пути_в_графе_wf
{ 
    public partial class Form1 : Form
    {
        double[,] matr;
        int vertices = 0;
        int pre_vertices = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int nachalo = comboBoxStart.SelectedIndex;
            int konec = comboBoxFinish.SelectedIndex;

            if (numericUpDownCountVertices.Value > 0 && nachalo < vertices && konec < vertices && nachalo != konec)
            {
                int visited_ind = 0;

                //Видиление памяти и запись в матрицу
                matr = new double[vertices, vertices];
                for (int i = 0; i < vertices; i++)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        bool flag_v = ValidationCell(j, i);
                        if (flag_v == false)
                        {
                            return;
                        }
                        else
                        {
                            matr[i, j] = Convert.ToInt32(dataGridViewMatrix[j, i].Value);
                        }
                    }
                }


                int[] visited = new int[vertices];

                for (int i = 0; i < vertices; i++)
                {
                    if (i == 0)
                    {
                        visited[0] = nachalo;
                    }
                    else
                    {
                        visited[i] = -1;
                    }
                }
                try
                {

                    if (listBox.SelectedIndices.Count > 0)
                    {
                        for (int i = 0; i < listBox.SelectedIndices.Count; i++)
                        {
                            visited_ind++;
                            visited[visited_ind] = listBox.SelectedIndices[i];
                        }
                    }

                    int[] way_p = new int[vertices];

                    for (int i = 0; i < vertices; i++)
                    {
                        way_p[i] = -1;
                    }

                    double[] length_way = new double[vertices];

                    for (int i = 0; i < vertices; i++)
                    {
                        if (i == nachalo)
                        {
                            length_way[i] = 0;
                        }

                        else
                        {
                            length_way[i] = Int32.MaxValue;
                        }
                    }

                    for (int i = 0; i < vertices; i++)
                    {
                        if (matr[nachalo, i] != 0)
                        {
                            way_p[i] = nachalo;
                            length_way[i] = matr[nachalo, i];
                        }
                    }

                    while (true)
                    {
                        double min_val = Int32.MaxValue;
                        int min_ind = 0;
                        min(length_way, visited, ref min_val, ref min_ind, ref visited_ind);
                        visited_ind++;
                        visited[visited_ind] = min_ind;

                        if (visited[visited_ind] == konec) { break; } // остановка
                        for (int i = 0; i < vertices; i++)
                        {
                            if (matr[min_ind, i] > 0)
                            {
                                double res = matr[min_ind, i] + min_val;

                                if (res < length_way[i])
                                {
                                    way_p[i] = min_ind;

                                    length_way[i] = res;
                                }
                            }
                        }
                    }

                    List<int> list_way = new List<int>();

                    int ptm = konec;
                    list_way.Add(konec);
                    while (ptm != nachalo)
                    {
                        list_way.Add(way_p[ptm]);
                        ptm = way_p[ptm];
                    }

                    list_way.Reverse();

                    textBoxWay.Text = null;
                    for (int i = 0; i < list_way.Count; i++)
                    {
                        textBoxWay.Text += dataGridViewListVertices[0, list_way[i]].Value.ToString();
                        if (i < list_way.Count - 1)
                        {
                            textBoxWay.Text += " -> ";
                        }

                    }

                    textBoxDistance.Text = length_way[konec].ToString();
                }
                catch (Exception etry)
                {
                    textBoxWay.Text = "Даного пути не существует.";
                    textBoxDistance.Text = "";
                }
            }
            else if (numericUpDownCountVertices.Value == 0)
            {
                MessageBox.Show("Выберете количество вершин ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (numericUpDownCountVertices.Value == 0) { numericUpDownCountVertices.BackColor = Color.OrangeRed; }
            }
            else if (nachalo >= vertices)
            {
                MessageBox.Show("Выбирете начальную вершину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (konec >= vertices)
            {
                MessageBox.Show("Выбирете конечную вершину!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nachalo == konec )
            {
                MessageBox.Show(" Начальная и конечная вершины совпадают ! ");
                if (listBox.GetSelected(nachalo) == false && Convert.ToInt32(dataGridViewMatrix[nachalo, konec].Value) > 0)
                {
                    textBoxWay.Text = nachalo.ToString();
                    textBoxDistance.Text = (dataGridViewMatrix[nachalo, konec].Value).ToString();
                }
                else
                {
                    textBoxWay.Text = "Даного пути не существует..";
                    textBoxDistance.Text = "";
                }
            }

        }
          
        void min(double[] length_way, int[] visited, ref double min_val, ref int min_ind, ref int visited_ind)
        {
            bool flag;
            for (int i = 0; i < vertices; i++)
            {
                if (length_way[i] < min_val && length_way[i] > 0)
                {
                    flag = visited_poisk(i, visited);
                    if (flag == false)
                    {
                        min_val = length_way[i];
                        min_ind = i;
                    }
                }
            }
        }

        bool visited_poisk(int ishem, int[] visited)
        {
            for (int i = 0; i < vertices; i++)
            {
                if (ishem == visited[i])
                {
                    return true;
                }
            }
            return false;
        }
        
        private void numericUpDownCountVertices_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCountVertices.BackColor = Color.White;
            p();
        }

        private void vvod()
        {
            if (comboBoxStart.SelectedIndex == -1)
            {
                comboBoxStart.SelectedItem = "Не выбрано"; 
            }
            if (comboBoxFinish.SelectedIndex == -1)
            {
                comboBoxFinish.SelectedItem = "Не выбрано";
            }
            try
            {
                if (dataGridViewListVertices[dataGridViewListVertices.CurrentCell.ColumnIndex, dataGridViewListVertices.CurrentCell.RowIndex].Value == null)
                {
                    dataGridViewListVertices[dataGridViewListVertices.CurrentCell.ColumnIndex, dataGridViewListVertices.CurrentCell.RowIndex].Value = "Вершина" + (dataGridViewListVertices.CurrentCell.RowIndex + 1).ToString();
                }

                //Запись в listBox вершины
                listBox.Items.RemoveAt(dataGridViewListVertices.CurrentCell.RowIndex);
                listBox.Items.Insert(dataGridViewListVertices.CurrentCell.RowIndex, (string)dataGridViewListVertices[0, dataGridViewListVertices.CurrentCell.RowIndex].Value);


                comboBoxStart.Items.RemoveAt(dataGridViewListVertices.CurrentCell.RowIndex);
                comboBoxStart.Items.Insert(dataGridViewListVertices.CurrentCell.RowIndex, (string)dataGridViewListVertices[0, dataGridViewListVertices.CurrentCell.RowIndex].Value);
                comboBoxFinish.Items.RemoveAt(dataGridViewListVertices.CurrentCell.RowIndex);
                comboBoxFinish.Items.Insert(dataGridViewListVertices.CurrentCell.RowIndex, (string)dataGridViewListVertices[0, dataGridViewListVertices.CurrentCell.RowIndex].Value);
            }
            catch
            {
                MessageBox.Show("количество вершин = 0 ");
            }
            
            // записать заголовки и запретить сортировку Matrix
            for (int i = 0; i < vertices; i++)
                {
                    dataGridViewMatrix.Rows[i].HeaderCell.Value = (string)dataGridViewListVertices[0, i].Value;
                    dataGridViewMatrix.Columns[i].HeaderText = (string)dataGridViewListVertices[0, i].Value;
                    dataGridViewMatrix.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
        }

        private void p()
        {
            //считать количество елементов 
            vertices = Convert.ToInt32(numericUpDownCountVertices.Value);

            //нарисовать матрицу вершин
            dataGridViewListVertices.RowCount = vertices;
            dataGridViewListVertices.ColumnCount = 1;

            ////нарисовать матрицу весов
            dataGridViewMatrix.RowCount = vertices;
            dataGridViewMatrix.ColumnCount = vertices;
            
            //начальные значения маттрицы Matrix
            if (vertices > pre_vertices)
            {
                for (int i = vertices - 1; i >= 0; i--)
                {
                    for (int j = 0; j < vertices; j++)
                    {
                        if (i < vertices - 1) { j = vertices - 1; }
                        dataGridViewMatrix[j, i].Value = 0;
                    }
                }
            }

            //начальные значения маттрицы вершин
            if (vertices > pre_vertices)
            {
                for (int j = vertices - 1; j < vertices; j++)
                {
                    dataGridViewListVertices[0, j].Value = "Вершина" + (j + 1).ToString();
                }
                int a = Convert.ToInt32(numericUpDownCountVertices.Value) - 1;
                listBox.Items.Insert(a, (string)dataGridViewListVertices[0, a].Value);
                comboBoxStart.Items.Insert(a, (string)dataGridViewListVertices[0, a].Value);
                comboBoxFinish.Items.Insert(a, (string)dataGridViewListVertices[0, a].Value);
            }
            else
            {
                listBox.Items.RemoveAt(Convert.ToInt32(numericUpDownCountVertices.Value));
                comboBoxStart.Items.RemoveAt(Convert.ToInt32(numericUpDownCountVertices.Value));
                comboBoxFinish.Items.RemoveAt(Convert.ToInt32(numericUpDownCountVertices.Value));
            }
            vvod();
            pre_vertices = vertices;

        }

        private void dataGridViewListVertices_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            vvod();
        }
       
        private bool ValidationCell(int col, int row)
        {
            int cellValue;
            if (dataGridViewMatrix[col, row].Value == null || (int.TryParse(dataGridViewMatrix[col, row].Value.ToString(), out cellValue)) == false || Convert.ToInt32(dataGridViewMatrix[col, row].Value) < 0)
            {
                MessageBox.Show("В матрице весов могут нахотится только неотрицательные ЧИСЛА, ячейки не могут быть пустыми!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridViewMatrix.Rows[row].Cells[col].Style.BackColor = Color.OrangeRed;
                return false;
            }
            if (dataGridViewMatrix.Rows[row].Cells[col].Style.BackColor != Color.Empty)
            {
                dataGridViewMatrix.Rows[row].Cells[col].Style.BackColor = Color.Empty;
            }
            return true;
        }

        private void dataGridViewMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ValidationCell(dataGridViewMatrix.CurrentCell.ColumnIndex, dataGridViewMatrix.CurrentCell.RowIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStart.Text = comboBoxStart.Items[0].ToString();
            comboBoxFinish.Text = comboBoxFinish.Items[0].ToString();
        }

        private void dataGridViewListVertices_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            // записать заголовки в названия вершин
            dataGridViewListVertices.Columns[0].HeaderText = "Имена вершин.         *(кликните на имя вершины для редактирования)";
        }
    }
}