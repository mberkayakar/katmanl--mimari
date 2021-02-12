using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FACADELAYER
{
    public class SQLBAGLANTİSİ
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-4DOAMQN;Initial Catalog=CokKatmanliMimari;Integrated Security=True");
    }
}


//Data Source=DESKTOP-4DOAMQN;Initial Catalog=CokKatmanliMimari;Integrated Security=True