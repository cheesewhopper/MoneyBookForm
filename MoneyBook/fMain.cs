namespace MoneyBook
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //�α����� ������.
                //1. �ڷḦ �ҷ��ͼ� ǥ��(���)
                //2. ��/��� ��� ��ư�� Ȱ��ȭ 
                btIN.Enabled = true; 
                btOut.Enabled = true; 
            }
            else
            {
                //�α����� ������.
                //1. ���� ǥ�õǴ� ��� ���� 
                //2. ��/��� ��� ��ư�� ��Ȱ�� 
                btIN.Enabled = false; // �Աݹ�ư ��Ȱ��
                btOut.Enabled = false; //// �Աݹ�ư ��Ȱ��
            }
        }

        private void btIN_Click(object sender, EventArgs e)
        {
            fIN f = new fIN();
            DialogResult result = f.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                //�����͸� �߰��Ѵ�. 
                
                DateTime �Է��� = f.dtDate.Value;
                string �з� = f.tbType.Text;
                string �ݾ� = f.tbAmt.Text;
                string ��� = f.tbMemo.Text;

                //������ �߰�
                //(�̱���)

                //��Ͽ� �߰� 
                ListViewItem lv =lv1.Items.Add(�Է���.ToShortDateString());
                lv.SubItems.Add(�з�);
                lv.SubItems.Add(�ݾ�);
                lv.SubItems.Add("");// ���
                lv.SubItems.Add(���);


            }
        }

        private void btOut_Click(object sender, EventArgs e)
        {
            fOut f = new fOut();
            DialogResult result = f.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //�����͸� �߰��Ѵ�. 

                DateTime �Է��� = f.dtDate.Value;
                string �з� = f.tbType.Text;
                string �ݾ� = f.tbAmt.Text;
                string ��� = f.tbMemo.Text;

                //������ �߰�
                //(�̱���)

                //��Ͽ� �߰� 
                ListViewItem lv = lv1.Items.Add(�Է���.ToShortDateString());
                lv.SubItems.Add(�з�);
                lv.SubItems.Add("");//�Ա�
                lv.SubItems.Add(�ݾ�);
                lv.SubItems.Add(���);


            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            //�����޴�
            if(lv1.SelectedItems.Count <1)
            {
                MessageBox.Show("���̺��� �����ϼ���");
                return;
            }

            //���õ� �ڷ��� ������ Ȯ���Ѵ�.
            ListViewItem lv =lv1.SelectedItems[0];
            string ��¥ = lv.SubItems[0].Text;
            string �з� = lv.SubItems[1].Text;
            string �Աݾ� = lv.SubItems[2].Text;
            string ��ݾ� = lv.SubItems[3].Text;
            string ��� = lv.SubItems[4].Text;


            if (�Աݾ� !="")
            {
                //�Ա�ȭ���� ȣ���ϰ� ���� �����͸� ����
                fIN f = new fIN(��¥, �з�, �Աݾ�,���);
                if(f.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    //���� ���õ� �ڷḦ ������Ʈ �մϴ�.
                    lv.SubItems[0].Text = f.dtDate.Value.ToShortDateString(); //2022-12-31
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = f.tbAmt.Text;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;
                }
            }
            else
            {
                //���ȭ���� ȣ���ϰ�...
                fOut f = new fOut(��¥, �з�, �Աݾ�, ���);
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //���� ���õ� �ڷḦ ������Ʈ �մϴ�.
                    lv.SubItems[0].Text = f.dtDate.Value.ToShortDateString(); //2022-12-31
                    lv.SubItems[1].Text = f.tbType.Text;
                    lv.SubItems[2].Text = f.tbAmt.Text;
                    lv.SubItems[3].Text = "";
                    lv.SubItems[4].Text = f.tbMemo.Text;

                }

            }

        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            //�����޴�
            if (lv1.SelectedItems.Count < 1)
            {
                MessageBox.Show("���̺��� �����ϼ���");
                return;
            }

            DialogResult result = MessageBox.Show("�����Ͻðڽ��ϴٱ�?", "����Ȯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == System.Windows.Forms.DialogResult.Yes)
            {
                ListViewItem lv = lv1.SelectedItems[0];
                lv1.Items.Remove(lv);
                MessageBox.Show("�����Ϸ�"); 
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //�����ϱ�
            //��¥, �з�, �Ա�, ���, ���
            string ���ϸ� = AppDomain.CurrentDomain.BaseDirectory + "Data\\2018-12.csv";
            string ���� = "";

            System.IO.File.WriteAllText(���ϸ�, ����);
            Console.WriteLine("�������ϸ�=" + ���ϸ�);
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            //�ҷ�����
            //
        }
    }
}