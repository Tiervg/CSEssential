using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Document
    {
        Title title;
        Body body;
        Footer footer;

        public Document(string title)
        {
            this.title = new Title() { Content = title };
            body = new Body();
            footer = new Footer();
        }

        public string BodyText { set { body.Content = value; } }
        public string FooterText { set { footer.Content = value; } }

        public void ShowDocument()
        {
            title.Show();
            body.Show();
            footer.Show();
        }

    }
}
