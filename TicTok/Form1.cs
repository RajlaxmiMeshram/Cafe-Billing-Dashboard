
namespace TicTok
{

    
    public partial class Form1 : Form
    {
        public int tea, coffee,sshake,cshake=0;
        public int cprice;
        public int tprice;
        public int sprice;
        public int coprice;

        public Form1()
        {


            InitializeComponent();

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            tea = tea+1
           tprice = 10 * tea;
            richTextBox1.AppendText("Tea    "+tea.ToString()+"   "+tprice.ToString()+ "\n");
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
           cshake= cshake+1;
            coprice = 150 + cshake;
            richTextBox1.AppendText("Chocolate Shake    " + cshake.ToString() + "   " + coprice.ToString() + "\n");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            coffee = coffee+1;
            cprice = 50 + coffee;
            richTextBox1.AppendText("Coffee   " + coffee.ToString() + "   " + cprice.ToString() + "\n");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            sshake = sshake + 1;
            sprice = 180 + sshake;
            richTextBox1.AppendText("Stawberry Shake   " + sshake.ToString() + "   " + sprice.ToString() + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }


    }
}