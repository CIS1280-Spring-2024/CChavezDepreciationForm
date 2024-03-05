using System.Windows.Forms;

namespace CChavezDepreciationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveFromInventory_Click(object sender, EventArgs e)
        {
            //  The remove button will remove the item selected in the list box from the list.
        }

        private void btnAddToInventory_Click(object sender, EventArgs e)
        {
            //  The Add form item to inventory button will do the following:
            //Instantiate the right type of depreciation object
            //(either DepreciationStraightLine or DepreciationDoubleDeclining).
            //Fill the properties of the that object from the controls on the form.
            //Add that object to the ListBox.
            DepreciationStraightLine dsl = new DepreciationStraightLine();
            dsl.Title = tbTitle.Text;
            dsl.StartValue = double.Parse(tbStartValue.Text);
            dsl.EndValue = double.Parse(tbEndValue.Text);
            dsl.Lifetime = double.Parse(tbLifetime.Text);
            dsl.IntoInventory = dtpDatein;
                 assign.Score = int.Parse(txbScore.Text);
            tbStartValue
      
                dtpDateIn
                dtpDateOut

            dsl.EndValue = tbEndValue.Text;
            assign.Score = int.Parse(txbScore.Text);
            lbScores.Items.Add(assign);

        }

        private void btAssessInventory_Click(object sender, EventArgs e)
        {
            //  The summary tab will just have a button that when clicked will iterate through the ListBox items and display the total value:
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbInventory_DoubleClick(object sender, EventArgs e)
        {
            //  Double clicking on an item in the list box should display it’s properties in the form controls.
        }
    }
}
