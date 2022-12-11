namespace TicTok
{
    
    public partial class Form1 : Form
    {
        public int tea, coffee,sshake,cshake=0;
        public int cprice=20;
        public int tprice=10;
        public int sprice = 130;
        public int coprice = 110;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            coffee = coffee + 1;
            cprice = cprice + coffee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tea = tea + 1;
           tprice = tprice + tea;
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}