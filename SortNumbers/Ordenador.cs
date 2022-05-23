
namespace SortNumbers
{
    public partial class Ordenador : Form
    {
        public Ordenador()
        {
            InitializeComponent();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {   
            string[] numbersString = this.txtNumbers.Text.Split(" ");
            int[] numbers = numbersString.Select(int.Parse).ToArray();
            Array.Sort(numbers);
            this.txtOrdered.Text = string.Join(" ", numbers);
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            string phrase = "{ \"number\":" + "\"" + this.txtOrdered.Text + "\"}";
            StreamWriter streamWriter;
            string path = "D:\\orderedNumber.txt";
            streamWriter = File.CreateText(path);
            streamWriter.WriteLine(phrase);
            streamWriter.Close();
        }
    }
   
}