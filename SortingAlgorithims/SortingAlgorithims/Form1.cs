using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithims
{
    public partial class SortingAlgoritimusForm : Form
    {
        public int[] array;
        public SortingAlgoritimusForm()
        {
            InitializeComponent();
        }

        private void SortingAlgoritimusForm_Load(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            /*
            string[] arr = arrayText.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            SortingAlgorithms s = new SortingAlgorithms();
            int[] array = arrayText.Text.ToArray;
            sortedArrayText.Text = s.insertionSort(array);
            */
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            List<string> arr = new List<string>();
            arr.AddRange(arrayText.Text.Split(',').Select(txt => txt.Trim()).ToArray());
            //Converting string array to int array
            array = arr.Select(s => int.Parse(s)).ToArray();
            SortingAlgorithms.insertionSort(array);
            sortedArrayText.Text = SortingAlgorithms.displayArray(array);


        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            arr.AddRange(arrayText.Text.Split(',').Select(txt => txt.Trim()).ToArray());
            //Converting string array to int array
            array = arr.Select(s => int.Parse(s)).ToArray();
            SortingAlgorithms.mergeSort(array , 0, array.Length - 1);
            sortedArrayText.Text = SortingAlgorithms.displayArray(array);

        }

    }


}
