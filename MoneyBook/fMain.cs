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
            string �Աݾ� = lv.SubItems[1].Text;
            string ��ݾ� = lv.SubItems[2].Text;
            if(�Աݾ� !="")
            {
                //�Ա�ȭ���� ȣ���ϰ� ���� �����͸� ����
                fIN f = new fIN();
                f.ShowDialog();
            }
            else
            {
                //���ȭ���� ȣ���ϰ�...
                fOut f = new fOut();
                f.ShowDialog();

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
        }
    }
}