using System;
using System.Collections;
using System.Data;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace DopemaHastanesi
{
    internal class Yonetim
    {

         
        #region Değişkenler
        public MySqlConnection _conn = new MySqlConnection("Server=localhost;database=dopeca;uid=root;pwd=;");
        public string _version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
  
        public string _hastaMail = "";
        public ArrayList _BransListele = new ArrayList();
        public ArrayList _HastaListele = new ArrayList();
        public ArrayList _BransDoktorListele = new ArrayList();
        public DataTable _bransTablosu = new DataTable();
        public DataTable _doktorTablosu = new DataTable();
        public DataTable _sekreterTablosu = new DataTable();
        public DataTable _sekreterRandevuTablosu = new DataTable();
        public DataTable _doktorRandevuTablosu = new DataTable();
        public DataTable _doktorTumRandevuTablosu = new DataTable();
        public DataTable _receteTablosu = new DataTable();
        public DataSet _doktorAraTablosu = new DataSet();
        public DataSet _sekreterAraTablosu = new DataSet();
        public DataSet _hastaAraTablosu = new DataSet();
        #endregion

        #region Hata_Mesajları
        public void msg01() { MessageBox.Show("Veritabanı Bağlantısı Olmadığından Uygulama Başlatılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg02() { MessageBox.Show("İnternet Bağlantısı Olmadığından Uygulama Başlatılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg03() { MessageBox.Show("Hatalı Kullanıcı Adı veya Parola Girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg04() { MessageBox.Show("Böyle kullanıcı tanımlı değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg05() { MessageBox.Show("İşlem Başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        public void msg06() { MessageBox.Show("Sunucu Hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg07() { MessageBox.Show("Bu kimlik numarası sisteme tanımlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg08() { MessageBox.Show("Sistemdeki veri ile eşleşemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        public void msg09() { MessageBox.Show("Bir sorun meydana geldi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        #endregion

        #region Veritabanı_Kontrolü
        public Boolean dbCheck()
        {
            try
            {
                _conn.Close();
                _conn.Open();
                if (_conn.State != ConnectionState.Closed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region DoktorSekreter_Giriş_Ekle_Sil_Güncelle
        public Boolean hesapGirisi(string a, string b)
        {
            try
            {
                _conn.Close();
                _conn.Open();
                MySqlCommand komut = new MySqlCommand("Select *From users where tckn ='" + a + "'", _conn);
                MySqlDataReader okuyucu = komut.ExecuteReader();
                if (okuyucu.Read())
                {
                    if (a == okuyucu["tckn"].ToString())
                    {
                        if (b == okuyucu["parola"].ToString())
                        {
                            Properties.Settings.Default.loginTc = okuyucu["tckn"].ToString();
                            Properties.Settings.Default.loginAdi = okuyucu["ad"].ToString()+ " " + okuyucu["soyad"].ToString();
                            Properties.Settings.Default.rutbe = okuyucu["rutbe"].ToString();
                            Properties.Settings.Default.Save();
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean doktorSekreterEkle(string a, string b, string c, string d, string e, string f, string g, string h, string j, string k, string l)
        {
            try
            {

                _conn.Close();
                _conn.Open();
                MySqlCommand add = new MySqlCommand("insert into users (tckn,ad,soyad,babaadi,dogumYeri,dogumTarihi,brans,cep,mail,parola,rutbe) values ('"
                    + a + "','"
                    + b + "','"
                    + c + "','"
                    + d + "','"
                    + e + "','"
                    + f + "','"
                    + g + "','"
                    + h + "','"
                    + j + "','"
                    + k + "','"
                    + l + "')", _conn);
                object sonuc = null;
                sonuc = add.ExecuteNonQuery();
                if (sonuc != null) { return true; }
                else { return false; }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public Boolean doktorSekreterSil(string a)
        {
            try
            {
                MySqlCommand delete = new MySqlCommand("DELETE FROM users WHERE tckn=@tckn", _conn);
                delete.Parameters.AddWithValue("@tckn", a);
                _conn.Close();
                _conn.Open();
                object sonuc = null;
                sonuc = delete.ExecuteNonQuery();
                _conn.Close();
                if (sonuc != null) { return true; }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean doktorSekreterGuncelle(string a, string b, string c, string d, string e, string f, string g, string h, string j, string k)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE  users  SET tckn = @tckn, ad = @ad, soyad= @soyad, babaadi=@babaadi, dogumYeri= @dogumYeri, dogumTarihi= @dogumTarihi, brans = @brans, cep = @cep, mail=@mail,parola = @parola where tckn=@tckn", _conn);
                cmd.Parameters.AddWithValue("@tckn", a);
                cmd.Parameters.AddWithValue("@ad", b);
                cmd.Parameters.AddWithValue("@soyad", c);
                cmd.Parameters.AddWithValue("@babaadi", d);
                cmd.Parameters.AddWithValue("@dogumYeri", e);
                cmd.Parameters.AddWithValue("@dogumTarihi", f);
                cmd.Parameters.AddWithValue("@brans", g);
                cmd.Parameters.AddWithValue("@cep", h);
                cmd.Parameters.AddWithValue("@mail", j);
                cmd.Parameters.AddWithValue("@parola", k);
                _conn.Close();
                _conn.Open();
                object sonuc = null;
                sonuc = cmd.ExecuteNonQuery();
                _conn.Close();
                if (sonuc != null) { return true; }
                else { return false; }
            }
            catch (Exception)
            { return false; }
        }
        #endregion

        #region BranşEkle_Sil_Güncelle
        public Boolean bransEkle(string a)
        {
            try
            {
                _conn.Close();
                _conn.Open();
                MySqlCommand add = new MySqlCommand("insert into branch (bransAdi) values ('" + a + "')", _conn);
                object sonuc = null;
                sonuc = add.ExecuteNonQuery();
                if (sonuc != null) { return true; }
                else { return false; }
                _conn.Close();
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean bransSil(string a)
        {
            try
            {
                MySqlCommand delete = new MySqlCommand("DELETE FROM branch WHERE bransAdi=@bransAdi", _conn);
                delete.Parameters.AddWithValue("@bransAdi", a);
                _conn.Close();
                _conn.Open();
                object sonuc = null;
                sonuc = delete.ExecuteNonQuery();
                _conn.Close();
                if (sonuc != null) { return true; }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public Boolean bransGuncelle(int a, string b)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE  branch  SET bransAdi = @bransAdi  where id=@id", _conn);
                cmd.Parameters.AddWithValue("@bransAdi", b);
                cmd.Parameters.AddWithValue("@id", a);
                _conn.Close();
                _conn.Open();
                object sonuc = null;
                sonuc = cmd.ExecuteNonQuery();
                _conn.Close();
                if (sonuc != null) { return true; }
                else { return false; }
            }
            catch (Exception)
            { return false; }
        }
        #endregion

        #region RandevuEKle_Sil_Güncelle
        public Boolean randevuEkle(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            try
            {
                _conn.Close();
                _conn.Open();
                MySqlCommand add = new MySqlCommand("insert into date (hastaTc,hastaAdi,doktorTc,brans,randevuTarihi,randevuSaati,sikayet,islemDurumu) values ('"
                    + a + "','"
                    + b + "','"
                    + c + "','"
                    + d + "','"
                    + e + "','"
                    + f + "','"
                    + g + "','"
                    + h + "')", _conn);
                object sonuc = null;
                sonuc = add.ExecuteNonQuery();
                if (sonuc != null) { return true; }
                else { return false; }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public Boolean randevuGuncelle(string a, string b)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE  date  SET islemDurumu = @islemDurumu where id=@id", _conn);
                cmd.Parameters.AddWithValue("@id", a);
                cmd.Parameters.AddWithValue("@islemDurumu", b);
                _conn.Close();
                _conn.Open();
                object sonuc = null;
                sonuc = cmd.ExecuteNonQuery();
                _conn.Close();
                if (sonuc != null) { return true; }
                else { return false; }
            }
            catch (Exception)
            { return false; }
        }
        public Boolean hastaEkle(string a, string b, string c, string d, string e, string f, string g, string h, string j)
        {
            try
            {
                _conn.Close();
                _conn.Open();
                MySqlCommand add = new MySqlCommand("insert into sickusers (tckn,ad,soyad,cinsiyet,dogumYeri,dogumTarihi,kanGrubu,cep,mail) values ('"
                    + a + "','"
                    + b + "','"
                    + c + "','"
                    + d + "','"
                    + e + "','"
                    + f + "','"
                    + g + "','"
                    + h + "','"
                    + j + "')", _conn);
                object sonuc = null;
                sonuc = add.ExecuteNonQuery();
                _conn.Close();
                if (sonuc != null) { return true; }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region İlaç Ekle
        public Boolean ilacEkle(string a, string b, string c)
        {
            try
            {
                _conn.Close();
                _conn.Open();
                MySqlCommand add = new MySqlCommand("insert into recete (hastaTc,doktorTc,ilac,tarih) values ('"
                    + a + "','"
                    + b + "','"
                    + c + "','"
                    + DateTime.Now.ToShortDateString() + "')", _conn);
                object sonuc = null;
                sonuc = add.ExecuteNonQuery();
                if (sonuc != null) { return true; }
                else { return false; }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        #region Koşullu_Veri_Aratmalar
        public void doktorAra(string a,string b)
        {
            
            _conn.Close();
            _conn.Open();          
            MySqlCommand komut = new MySqlCommand("select * from users where "+a+" like '%" + b + "%' AND rutbe = '1'", _conn);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            da.Fill(_doktorAraTablosu);
            _conn.Close();
            
        }
        public void sekreterAra(string a)
        {
            _conn.Close();
            _conn.Open();
            MySqlCommand komut = new MySqlCommand("select * from users where tckn like '%" + a + "%' AND rutbe ='2'", _conn);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            da.Fill(_sekreterAraTablosu);
            _conn.Close();

        }
        public void hastTcGoreMailAra(string a)
        {
            try
            {
                _conn.Close();
                _conn.Open();
                MySqlCommand doldur = new MySqlCommand("Select * From sickusers where tckn ='" + a + "'", _conn);
                MySqlDataReader dr = doldur.ExecuteReader();
                while (dr.Read())
                {
                    _hastaMail = dr["mail"].ToString();
                }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.ToString());
            }
            _conn.Close();
        }
        public void hastaAra(string a)
        {

            _conn.Close();
            _conn.Open();
            MySqlCommand komut = new MySqlCommand("select * from date where hastaTc like '%" + a + "%'", _conn);
            MySqlDataAdapter da = new MySqlDataAdapter(komut);
            da.Fill(_hastaAraTablosu);
            _conn.Close();

        }

        #endregion

        #region Tablo_Veri_Aktarmalar
        public void bransListele()
        {
            try
            {
                _BransListele.Clear();
                _conn.Close();
                _conn.Open();
                MySqlCommand doldur = new MySqlCommand("select bransAdi from branch", _conn);
                MySqlDataReader dr = doldur.ExecuteReader();
                while (dr.Read())
                {
                    _BransListele.Add(dr[0]);
                }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.ToString());
            }
        }
        public void bransaGoreDoktorAra(string a)
        {
            try
            {
                _BransDoktorListele.Clear();
                _conn.Close();
                _conn.Open();

                MySqlCommand doldur = new MySqlCommand("Select * From users where brans ='" + a + "'", _conn);
                MySqlDataReader dr = doldur.ExecuteReader();
                while (dr.Read())
                {
                    _BransDoktorListele.Add(dr["tckn"].ToString() + " / "+dr["ad"].ToString() + " " + dr["soyad"].ToString());
                }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.ToString());
            }
            _conn.Close();
        }
        public void bransGetir()
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM branch", _conn);
            adtr.Fill(_bransTablosu);
        }
        public void doktorGetir()
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM users Where rutbe = '1'", _conn);
            adtr.Fill(_doktorTablosu);
        }
        public void sekreterGetir()
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM users Where rutbe = '2'", _conn);
            adtr.Fill(_sekreterTablosu);

        }
        public void sekreterRandevuGetir()
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM date Where islemDurumu = 'Bekleniyor...'  ORDER BY id DESC", _conn);
            adtr.Fill(_sekreterRandevuTablosu);
        }
        public void doktorRandevuGetir(string a)
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM date Where doktorTc =  " + a + "  AND islemDurumu = 'Bekleniyor...' AND randevuTarihi = '" + DateTime.Now.ToShortDateString() + "' ORDER BY id DESC", _conn);
            adtr.Fill(_doktorRandevuTablosu);
        }
        public void doktorTumRandevuGetir(string a)
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM date Where doktorTc =  " + a + "  ORDER BY id DESC", _conn);
            adtr.Fill(_doktorTumRandevuTablosu);
        }
        public void receteGetir(string a)
        {
            MySqlDataAdapter adtr = new MySqlDataAdapter("SELECT * FROM recete Where doktorTc =  " + a + "  ORDER BY id DESC", _conn);
            adtr.Fill(_receteTablosu);
        }
        public void hastaListeleFonk()
        {
            try
            {
                _HastaListele.Clear();
                _conn.Close();
                _conn.Open();
                MySqlCommand doldur = new MySqlCommand("select tckn,ad,soyad from sickusers", _conn);
                MySqlDataReader dr = doldur.ExecuteReader();
                while (dr.Read())
                {
                    _HastaListele.Add(dr[0]+ " / " + dr[1] + " " +dr[2]);
                }
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.ToString());
            }
        }
        #endregion

        #region Mail_Gönderme
        public Boolean mesajGonderA(string a, string b,string c)
        {
            /* try
             {
                 SmtpClient sc = new SmtpClient();
                 sc.Port = 587;
                 sc.Host = "smtp.gmail.com";
                 sc.EnableSsl = true;
                 sc.Credentials = new NetworkCredential("xx@gmail.com", "xx");
                 MailMessage mail = new MailMessage();
                 mail.From = new MailAddress("noreply@gmail.com", "DOPEMA Hastanesi");
                 mail.To.Add(a);
                 mail.Subject = b; mail.IsBodyHtml = true; mail.Body = c;
                 sc.Send(mail);
                 return true;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
                 return false;
             }*/
            return false;
        }

        #endregion

        #region Excel
        public void gonderExcel(DataGridView dataGridView1)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
        #endregion


    }
}