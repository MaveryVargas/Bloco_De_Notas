namespace WinFormsApp1
{
    public partial class Bloco_de_notas : Form
    {
        public Bloco_de_notas()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); // comando close é utilizado para fechar aplicação
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_RichTextBox.Font = fontDialog1.Font; //essa caixa de dialogo é encontrada na toolbox
            }
        }

        private void coresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //"Show Dialgo" é o menu de escolher as fontes
            {
                Txt_RichTextBox.ForeColor = colorDialog1.Color;

            }
        }

        //função para salvar o arquivo, utilizando o save dialog do windows forms
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, Txt_RichTextBox.Text);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Txt_RichTextBox.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txt_RichTextBox.Clear();
        }
    }
}