using System;
using System.Windows.Forms;

namespace BlackjackSwitchCalculator
{
    public partial class MainForm : Form
    {
        decimal[,] bjScore = new decimal[,] 
        {
            { -0.2688m, -0.1884m, -0.1531m, -0.1165m, -0.087m, -0.1571m, -0.2232m, -0.2992m, -0.3965m, -0.5188m }, // 5
            { -0.2821m, -0.2007m, -0.1647m, -0.1275m, -0.0989m, -0.1882m, -0.251m,  -0.3241m, -0.4179m, -0.5358m }, // 6
            { -0.2517m, -0.1703m, -0.1352m, -0.0998m, -0.0569m, -0.1165m, -0.2551m, -0.326m,  -0.4091m, -0.545m }, // 7
            { -0.1649m, -0.0859m, -0.0535m, -0.0218m,  0.0288m,  0.0334m, -0.1054m, -0.2527m, -0.3466m, -0.4678m }, // 8
            { -0.0692m,  0.0072m,  0.0365m,  0.0654m,  0.143m,   0.122m,   0.0519m, -0.0956m, -0.2584m, -0.3774m}, // 9
            { 0.0561m,  0.2162m,  0.2716m,  0.3269m,  0.4016m,  0.2632m,  0.1661m,  0.0722m, -0.0947m, -0.2761m }, // 10
            { 0.1678m,  0.3247m,  0.3767m,  0.4291m,  0.4934m,  0.3336m,  0.2301m,  0.1152m, -0.0078m, -0.2334m }, // 11
            { -0.3549m, -0.3005m, -0.2791m, -0.2575m, -0.2308m, -0.2463m, -0.3028m, -0.3691m, -0.4557m, -0.5666m }, // 12
            { -0.4009m, -0.3488m, -0.3057m, -0.26m,   -0.2407m, -0.3001m, -0.3526m, -0.4142m, -0.4946m, -0.5976m }, // 13
            { -0.4437m, -0.3488m, -0.3057m, -0.26m,   -0.2407m, -0.3501m, -0.3988m, -0.456m,  -0.5307m, -0.6263m }, // 14
            { -0.4442m, -0.3488m, -0.3057m, -0.26m,   -0.2407m, -0.3965m, -0.4418m, -0.4949m, -0.5642m, -0.653m }, // 15
            { -0.4442m, -0.3488m, -0.3057m, -0.26m,   -0.2407m, -0.4396m, -0.4816m, -0.531m,  -0.5953m, -0.6778m }, // 16
            { -0.3044m, -0.2138m, -0.1752m, -0.1378m, -0.0753m, -0.1714m, -0.4422m, -0.4794m, -0.5166m, -0.6701m }, // 17
            { -0.0297m,  0.0517m,  0.0812m,  0.1067m,  0.1964m,  0.3349m,  0.0457m, -0.2394m, -0.2938m, -0.4085m }, // 18
            { 0.2349m,  0.3078m,  0.3285m,  0.3467m,  0.409m,   0.5514m,  0.5336m,  0.2313m, -0.0709m, -0.1469m }, // 19
            { -0.0851m, -0.0194m,  0.0106m,  0.0408m,  0.0757m,  0.0767m,  0.0114m, -0.0763m, -0.2095m, -0.3689m }, // A,2
            { -0.1199m, -0.0429m, -0.012m,   0.0193m,  0.0531m,  0.0355m, -0.0278m, -0.1123m, -0.2402m, -0.3934m }, // A,3
            { -0.1432m, -0.0648m, -0.033m,  -0.0006m,  0.0321m, -0.0053m, -0.0666m, -0.148m,  -0.2705m, -0.4177m }, // A,4
            { -0.1647m, -0.0851m, -0.0525m, -0.0192m,  0.0126m, -0.0456m, -0.1048m, -0.1831m, -0.3004m, -0.4416m }, // A,5
            { -0.1447m, -0.0653m, -0.0333m, -0.0014m,  0.0821m,  0.0029m, -0.1204m, -0.1932m, -0.299m,  -0.4563m }, // A,6
            { -0.0297m,  0.0517m,  0.0812m,  0.1096m,  0.2075m,  0.3349m,  0.0457m, -0.1451m, -0.2508m, -0.3968m }, // A,7
            { 0.2349m,  0.3078m,  0.3285m,  0.3467m,  0.409m,   0.5514m,  0.5336m,  0.2313m, -0.0709m, -0.1469m }, // A,8
            { 0.4885m,  0.5537m,  0.5664m,  0.5775m,  0.6169m,  0.7086m,  0.7315m,  0.7021m,  0.3827m,  0.1147m }, // A,9
            {      1m,       1m,       1m,       1m,       1m,       1m,       1m,       1m,  0.9231m,  0.6923m }, // A,10
            { 0.1678m,  0.3247m,  0.3767m,  0.4291m,  0.4934m,  0.3336m,  0.2301m,  0.1152m, -0.0925m, -0.3442m }, // A,A
            { -0.2546m, -0.1755m, -0.1407m, -0.0972m, -0.0063m, -0.1128m, -0.1957m, -0.2744m, -0.3752m, -0.5018m }, // 2,2
            { -0.2821m, -0.2007m, -0.1647m, -0.1264m, -0.0413m, -0.1701m, -0.251m,  -0.3241m, -0.4179m, -0.5358m }, // 3,3
            { -0.1649m, -0.0859m, -0.0535m, -0.0218m,  0.0288m,  0.0334m, -0.1054m, -0.2527m, -0.3466m, -0.4678m }, // 4,4
            { 0.0561m,  0.2162m,  0.2716m,  0.3269m,  0.4016m,  0.2632m,  0.1661m,  0.0722m, -0.0947m, -0.2761m }, // 5,5
            { -0.3549m, -0.3005m, -0.2791m, -0.1879m, -0.1013m, -0.2463m, -0.3028m, -0.3691m, -0.4557m, -0.5666m }, // 6,6
            { -0.4437m, -0.293m,  -0.2085m, -0.1236m, -0.0084m, -0.1892m, -0.3988m, -0.456m,  -0.5307m, -0.6263m }, // 7,7
            { -0.2968m, -0.0992m, -0.0211m,  0.0551m,  0.1806m,  0.1681m, -0.1596m, -0.5014m, -0.5953m, -0.4814m }, // 8,8
            { -0.0297m,  0.0517m,  0.1047m,  0.1723m,  0.2665m,  0.3349m,  0.1207m, -0.1838m, -0.2938m, -0.4085m }, // 9,9
            { 0.4885m,  0.5537m,  0.5664m,  0.5775m,  0.6169m,  0.7086m,  0.7315m,  0.7021m,  0.3827m,  0.1147m } // 10,10
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            txtStrategy.Clear();

            if (int.TryParse(txtDealerUpCard.Text, out int cardDL) && int.TryParse(txtHand1Card1.Text, out int cardP1) && int.TryParse(txtHand1Card2.Text, out int cardP3) &&
                int.TryParse(txtHand2Card1.Text, out int cardP2) && int.TryParse(txtHand2Card2.Text, out int cardP4) && cardDL >= 2 && cardDL <= 11 && cardP1 >= 2 &&
                cardP1 <= 11 && cardP2 >= 2 && cardP2 <= 11 && cardP3 >= 2 && cardP3 <= 11 && cardP4 >= 2 && cardP4 <= 11)
            {
                cardDL -= 2;
                cardP1 -= 2;
                cardP2 -= 2;
                cardP3 -= 2;
                cardP4 -= 2;

                decimal hand1NS = bjScore[rowIndex(cardP1, cardP3), cardDL];
                decimal hand2NS = bjScore[rowIndex(cardP2, cardP4), cardDL];
                decimal scoreNS = hand1NS + hand2NS;

                decimal hand1SW = bjScore[rowIndex(cardP1, cardP4), cardDL];
                decimal hand2SW = bjScore[rowIndex(cardP2, cardP3), cardDL];
                decimal scoreSW = hand1SW + hand2SW;

                if (scoreNS >= scoreSW)
                {
                    txtStrategy.Text = "No switch";
                }
                else
                {
                    txtStrategy.Text = "Switch";
                }
            }
        }

        private int rowIndex(int c1, int c2)
        {
            var ri = c1 + c2 - 1;

            if (c1 == c2) { ri = c1 + 25; }
            if (c1 == 9) { ri = c2 + 15; }
            if (c2 == 9) { ri = c1 + 15; }

            return ri;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDealerUpCard.Clear();
            txtHand1Card1.Clear();
            txtHand1Card2.Clear();
            txtHand2Card1.Clear();
            txtHand2Card2.Clear();
        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = chkTopMost.Checked;
        }
    }
}
