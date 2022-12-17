
namespace TicTok
{

    
    public partial class Form1 : Form
    {
        public int tea, coffee,sshake,cshake=0,tprice,sprice,coprice, cprice;
        string totalamount = null;

       
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
             
   

            tea = tea +1;
           tprice = 10 * tea;
            richTextBox1.AppendText("Tea\t\t\t\t    "+tea.ToString()+"   "+tprice.ToString()+ "\n");
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

                int coprice1=0;

            
       
        cshake= cshake +1;
            coprice = 150 * cshake;
            coprice1 += coprice;

            richTextBox1.AppendText("Chocolate Shake\t \t \t" + cshake.ToString() + "   " + coprice.ToString() + "\n");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        
        coffee = coffee ++;
            cprice = 50 *coffee;
            richTextBox1.AppendText("Coffee \t\t\t\t  " + coffee.ToString() + "   " + cprice.ToString() + "\n");
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            
        sshake = sshake ++;
            sprice = 180 * sshake;
            richTextBox1.AppendText("Stawberry Shake \t \t\t " + sshake.ToString() + "   " + sprice.ToString() + "\n");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int sum = this.cprice + this.coprice + this.sprice + this.tprice;
            totalamount = sum.ToString();
            textBox1.Text = totalamount;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           // richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
         //  richTextBox1.AppendText("\t\t" + "Cafe House" + Environment.NewLine);
           // richTextBox1.AppendText("-------------------------------------------------------------" + Environment.NewLine);
           // richTextBox1.AppendText("Tea \t\t\t\t" + Environment.NewLine);



            

        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Rs: " + this.totalamount + " Successfully Printed!");
        }


    }
}