using Estructuras_dinámicas_lineales.Clases;

namespace Estructuras_dinámicas_lineales

{
    public partial class Form1 : Form
    {
        public HistoryList<DocState> history;
        public Form1()
        {
            InitializeComponent();
            history = new HistoryList<DocState>(new DocState(""));
            UpdateButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarEstado_Click(object sender, EventArgs e)
        {
            history.Push(new DocState(TxtMult.Text));
            UpdateButton();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            var state = history.UndoOrdefault(new DocState(TxtMult.Text));
            TxtMult.Text = state.Text;
            UpdateButton();
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            var state = history.RedoOrdefault(new DocState(TxtMult.Text));
            TxtMult.Text = state.Text;
            UpdateButton();
        }

        private void UpdateButton()
        {
            BtnUndo.Enabled = history.CanUndo;
            BtnRedo.Enabled = history.CanRendo;
        }
    }
}
