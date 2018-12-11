using System.Windows.Forms;

namespace UcaksavarOyunu.Lib
{
    public abstract class OyunBase
    {
        protected readonly ContainerControl container;

        protected OyunBase(ContainerControl container)
        {
            this.container = container;
            this.Container = container;
        }
        public PictureBox Resim { get; set; } = new PictureBox();
        public ContainerControl Container { get; set; }
    }
}
