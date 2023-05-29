-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 29 May 2023, 23:26:46
-- Sunucu sürümü: 10.4.28-MariaDB
-- PHP Sürümü: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `dopeca`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `branch`
--

CREATE TABLE `branch` (
  `id` int(11) NOT NULL,
  `bransAdi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `branch`
--

INSERT INTO `branch` (`id`, `bransAdi`) VALUES
(1, 'Acil Servis'),
(2, 'Ağız, Çene ve Diş Sağlığı'),
(3, 'Alerji Hastalıkları\r\n'),
(4, 'Anesteziyoloji'),
(5, 'Başhekimlik\r\n'),
(6, 'Beslenme ve Diyet'),
(7, 'Beyin ve Sinir Cerrahisi'),
(8, 'Check Up'),
(9, 'Cildiye (Dermatoloji)'),
(10, 'Çocuk Cerrahisi'),
(11, 'Çocuk Kardiyolojisi'),
(12, 'Çocuk Sağlığı ve Hastalıkları'),
(13, 'Endoskopi'),
(14, 'Estetik Plastik ve Rekonstrüktif Cerrahi'),
(15, 'Fizik Tedavi ve Rehabilitasyon'),
(16, 'Gastroenteroloji'),
(17, 'Genel Cerrahi'),
(18, 'Genel Yoğun Bakım'),
(19, 'Göğüs Hastalıkları ve Alerji'),
(20, 'Göz Hastalıkları'),
(21, 'İç Hastalıkları (Dahiliye)'),
(22, 'İmplant'),
(23, 'Kadın Doğum (Obstetri)'),
(24, 'Kadın Hastalıkları (Jinekoloji)'),
(25, 'Kardiyoloji'),
(26, 'Kulak Burun Boğaz (KBB)'),
(27, 'Nefroloji'),
(28, 'Nöroloji'),
(29, 'Ortodonti'),
(30, 'Ortopedi ve Travmatoloji'),
(31, 'Psikoloji'),
(32, 'Radyoloji'),
(33, 'Tıbbi Laboratuvar'),
(34, 'Üroloji'),
(35, 'Yenidoğan Yoğun Bakım');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `date`
--

CREATE TABLE `date` (
  `id` int(11) NOT NULL,
  `hastaTc` text NOT NULL,
  `hastaAdi` text NOT NULL,
  `doktorTc` text NOT NULL,
  `brans` text NOT NULL,
  `randevuTarihi` text NOT NULL,
  `randevuSaati` text NOT NULL,
  `sikayet` text NOT NULL,
  `islemDurumu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `date`
--

INSERT INTO `date` (`id`, `hastaTc`, `hastaAdi`, `doktorTc`, `brans`, `randevuTarihi`, `randevuSaati`, `sikayet`, `islemDurumu`) VALUES
(79, '82358875950', 'Mahmut Aşık', '15640047254', 'Anesteziyoloji', '26.03.2022', '08:00', 'qwwe', 'Bekleniyor...'),
(80, '82358875950', 'Mahmut Aşık', '32029975052', 'Acil Servis', '26.03.2022', '08:00', 'qwe', 'Bekleniyor...'),
(81, '82358875950', 'Mahmut Aşık', '32029975052', 'Acil Servis', '26.03.2022', '14:30', '', 'Bekleniyor...'),
(82, '82358875950', 'Mahmut Aşık', '51939390212', 'Acil Servis', '23.06.2023', '11:00', 'lorem', 'Bekleniyor...'),
(83, '82358875950', 'Mahmut Aşık', '51939390212', 'Acil Servis', '30.05.2023', '08:00', 'test test ', 'Tamamlandı!');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `recete`
--

CREATE TABLE `recete` (
  `id` int(11) NOT NULL,
  `hastaTc` text NOT NULL,
  `doktorTc` text NOT NULL,
  `ilac` text NOT NULL,
  `tarih` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `recete`
--

INSERT INTO `recete` (`id`, `hastaTc`, `doktorTc`, `ilac`, `tarih`) VALUES
(4, '82358875950', '51939390212', 'Lorem,lorem lorem 5x 200mg', '30.05.2023');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sickusers`
--

CREATE TABLE `sickusers` (
  `id` int(11) NOT NULL,
  `tckn` text NOT NULL,
  `ad` text NOT NULL,
  `soyad` text NOT NULL,
  `cinsiyet` text NOT NULL,
  `dogumYeri` text NOT NULL,
  `dogumTarihi` text NOT NULL,
  `kanGrubu` text NOT NULL,
  `cep` text NOT NULL,
  `mail` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `sickusers`
--

INSERT INTO `sickusers` (`id`, `tckn`, `ad`, `soyad`, `cinsiyet`, `dogumYeri`, `dogumTarihi`, `kanGrubu`, `cep`, `mail`) VALUES
(15, '82358875950', 'Mahmut', 'Aşık', 'Erkek', 'Mersin', '29.01.1999', '0RH+', '(111) 111-1111', 'niqitheck@gmail.com');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `tckn` text NOT NULL,
  `ad` text NOT NULL,
  `soyad` text NOT NULL,
  `babaadi` text NOT NULL,
  `dogumYeri` text NOT NULL,
  `dogumTarihi` text NOT NULL,
  `brans` text NOT NULL,
  `cep` text NOT NULL,
  `mail` text NOT NULL,
  `parola` text NOT NULL,
  `rutbe` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `users`
--

INSERT INTO `users` (`id`, `tckn`, `ad`, `soyad`, `babaadi`, `dogumYeri`, `dogumTarihi`, `brans`, `cep`, `mail`, `parola`, `rutbe`) VALUES
(1, '32029975052', 'Aleyna', 'Özer', 'Ali', 'Çankırı', '6.03.1970', 'Acil Servis', '(111) 111-1111', 'test@localhost', '123123', '1'),
(2, '10677168972', 'Ceren', 'Güneş', 'Burak', 'Kırşehir', '6.03.2022', 'Ağız, Çene ve Diş Sağlığı', '(111) 111-1111', 'test@localhost', 'd1701f54', '1'),
(3, '12312319191', 'Doğukan', 'Pusat', 'Test', 'Erzurum', '10.03.2000', 'Sekreter', '(111) 111-1111', 'test@localhost', '123123', '2'),
(4, 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', '0'),
(9, '12312319192', 'Deren', 'Keskin', 'Yusuf', 'Eskişehir', '26.03.2001', 'Genel Cerrahi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(10, '51939390212', 'Halil', 'Avci', 'Kerem', 'Gaziantep', '23.11.1987', 'Acil Servis', '(111) 111-1111', 'test@localhost', '123123', '1'),
(11, '76100053888', 'Medine', 'Yılmaz', 'Murat', 'Nevşehir', '23.11.1990', 'Ağız, Çene ve Diş Sağlığı', '(111) 111-1111', 'test@localhost', '123123', '1'),
(12, '29001558426', 'Derya', 'Erdoğan', 'Mustafa', 'Iğdır', '23.11.1950', 'Alerji Hastalıkları\r\n', '(111) 111-1111', 'test@localhost', '123123', '1'),
(13, '79133536748', 'Yunus Emre', 'Yavuz ', 'Serkan', 'Antalya', '23.11.1950', 'Alerji Hastalıkları\r\n', '(111) 111-1111', 'test@localhost', '123123', '1'),
(14, '15640047254', 'Serkan', 'Özcan', 'Neşet', 'Niğde', '23.11.1966', 'Cildiye (Dematoloji)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(15, '78586628550', 'Yağmur', 'Arslan', 'Akif', 'Kars', '27.03.1997', 'Genel Cerrahi', '(222) 222-2222', 'test@localhost', '123123', '1'),
(16, '60242057736', 'Serkan', 'Aydın', 'Cem', 'Bingöl', '20.04.1990', 'Anesteziyoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(17, '85585311208', 'Mert', 'Özcan', 'Deniz', 'Balıkesir', '20.04.1987', 'Anesteziyoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(18, '77506125520', 'Ayten', 'Bozkurt', 'Kürşat', 'Sakarya', '20.04.1986', 'Başhekimlik\r\n', '(111) 111-1111', 'test@localhost', '123123', '1'),
(19, '78034130758', 'Berfin ', 'Acar', 'Muhittin', 'Rize', '20.04.1986', 'Başhekimlik\r\n', '(111) 111-1111', 'test@localhost', '123123', '1'),
(20, '44835271532', 'Ela ', 'Aslan', 'Sabri', 'Denizli', '20.04.1970', 'Check Up', '(111) 111-1111', 'test@localhost', '123123', '1'),
(21, '52460268698', 'Hasan', 'Utku', 'İlyas', 'Amasya', '20.04.1998', 'Check Up', '(111) 111-1111', 'test@localhost', '123123', '1'),
(22, '65187603758', 'Sude Naz', 'Korkmaz', 'Hüseyin', 'Ankara', '20.04.1960', 'Cildiye (Dematoloji)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(23, '17864639352', 'Mehmet ', 'Aydın', 'Mehmet', 'Sakarya', '20.04.1980', 'Beslenme ve Diyet', '(111) 111-1111', 'test@localhost', '123123', '1'),
(24, '71292315684', 'Cemre', 'Denli', 'Harun', 'Samsun', '20.04.1997', 'Beslenme ve Diyet', '(111) 111-1111', 'test@localhost', '123123', '1'),
(25, '66786008944', 'Ayşe', 'Keskin', 'Hasan', 'Van', '20.04.1996', 'Beyin ve Sinir Cerrahisi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(26, '43794460636', 'Ayşe Nur', 'Kan', 'Demir', 'Elazığ', '20.04.1994', 'Beyin ve Sinir Cerrahisi', '(111) 111-1111', 'test@ocalhost', '123123', '1'),
(27, '57817567714', 'Nurten', 'Soy', 'Hüseyin', 'Edirne', '20.04.1992', 'Genel Cerrahi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(28, '71349456964', 'Rüya ', 'Yıldız', 'Hasan', 'Balıkesir', '20.04.1991', 'Çocuk Cerrahisi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(29, '79984544022', 'Gamze', 'Erdoğan', 'Kemal', 'Gaziantep', '20.04.1990', 'Çocuk Cerrahisi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(30, '37079066514', 'Mehmet', 'Sarş', 'Volkan', 'Siirt', '20.04.1991', 'Çocuk Kardiyolojisi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(31, '82718329482', 'Nisa', 'Öztürk', 'Onur', 'Denizli', '10.04.1991', 'Çocuk Kardiyolojisi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(32, '53702734056', 'İlayda', 'Aslan', 'Emrah', 'Elazığ', '10.04.1991', 'Çocuk Sağlığı ve Hastalıkları', '(111) 111-1111', 'test@localhost', '123123', '1'),
(33, '41234125234', 'Cemre', 'Gündüz', 'Rıdvan', 'Hakkâri', '15.04.1991', 'Çocuk Sağlığı ve Hastalıkları', '(111) 111-1111', 'test@localhost', '123123', '1'),
(34, '12143523423', 'Ramazan', 'Doğan', 'Ali', 'Gümüşhane', '30.04.1991', 'Endoskopi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(35, '23523512352', 'Abdullah ', 'Korkmaz', 'Erdem', 'Diyarbakır', '10.04.1991', 'Endoskopi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(36, '48935319798', 'Esra', 'Yıldırım', 'Mert', 'Samsun', '10.04.1980', 'Estetik Plastik ve Rekonstrüktif Cerrahi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(37, '98159845740', 'Hiranur', 'Yüksel', 'İrfan', 'Sinop', '10.04.1977', 'Estetik Plastik ve Rekonstrüktif Cerrahi', '(111) 111-1111', 'test@localhost', '123123', '1'),
(38, '69164664114', 'Mert', 'Korkmaz', 'Cem', 'Erzurum', '10.04.1989', 'Fizik Tedavi ve Rehabilitasyon', '(111) 111-1111', 'test@localhost', '123123', '1'),
(39, '68434415128', 'Burak', 'Kaya', 'Batuhan', 'Sakarya', '10.04.1999', 'Fizik Tedavi ve Rehabilitasyon', '(111) 111-1111', 'test@llocalhost', '123123', '1'),
(40, '60874237940', 'Murat', 'Şen', 'Abdullah', 'Hatay', '10.04.1987', 'Gastroenteroloji', '(111) 111-1111', 'test@ocalhost', '123123', '1'),
(41, '33756243766', 'Batuhan', 'Kartal', 'Emrah', 'Gümüşhane', '10.04.1976', 'Gastroenteroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(42, '21342134213', 'Adnan', 'Aktaş', 'Mehmet', 'Edirne', '10.04.1990', 'Genel Yoğun Bakım', '(111) 111-1111', 'test@localhost', '123123', '1'),
(43, '94913012076', 'Baran ', 'Özkan', 'Adnan', 'Edirne', '10.04.1989', 'Genel Yoğun Bakım', '(111) 111-1111', 'test@localhost', '123123', '1'),
(44, '75509340452', 'Hülya', 'Acar', 'Adnan', 'Gaziantep', '10.04.1987', 'Göğüs Hastalıkları ve Alerji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(45, '99491731890', 'Arda', 'Erdoğan', 'Tuncay', 'Düzce', '10.04.1990', 'Göğüs Hastalıkları ve Alerji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(46, '23997736028', 'İbrahim', 'Can', 'Adem', 'Yalova', '10.04.1970', 'Göz Hastalıkları', '(111) 111-1111', 'test@localhost', '123123', '1'),
(47, '32542512341', 'Adem', 'Hakkı', 'Remzi', 'Malatya', '10.04.1960', 'Gastroenteroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(48, '80783770864', 'Ayten', 'Turan', 'Adem', 'Yozgat', '10.04.1980', 'Göz Hastalıkları', '(111) 111-1111', 'test@localhost', '123123', '1'),
(49, '82521273156', 'Burcu', 'Keskin', 'Vedat', 'Uşak', '10.04.1990', 'Gastroenteroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(50, '28804766922', 'İbrahim', 'Can', 'İbrahim', 'Kahramanmaraş', '10.04.1978', 'İç Hastalıkları (Dahiliye)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(51, '70906672984', 'Samet', 'Bulut', 'İsmet', 'Tekirdağ', '10.04.1996', 'İç Hastalıkları (Dahiliye)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(52, '63609207362', 'Gökhan', 'Erdem', 'İsmet', 'Gaziantep', '10.04.1999', 'İmplant', '(111) 111-1111', 'test@localhost', '123123', '1'),
(53, '33129916228', 'Yiğit ', 'Yılmaz', 'Umut', 'Eskişehir', '10.04.1998', 'İmplant', '(111) 111-1111', 'test@localhost', '123123', '1'),
(54, '98279016990', 'Aynur', 'Şimşek', 'Erdem', 'Bingöl', '10.04.1998', 'Kadın Doğum (Obstetri)', '(111) 111-1111', 'test@locahost', '123123', '1'),
(55, '17138559942', 'Sümeyye', 'Çelik', 'Muhammed', 'Bayburt', '10.04.1996', 'Kadın Doğum (Obstetri)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(56, '19567205780', 'Elif', 'Erdoğan', 'Erdoğan', 'Ordu', '10.04.1995', 'Kadın Hastalıkları (Jinekoloji)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(57, '52149351864', 'Elif', 'Olgun', 'Osman', 'Balıkesir', '10.04.1994', 'Kadın Hastalıkları (Jinekoloji)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(58, '17335632752', 'Osman', 'Keskin', 'Cemil', 'Yalova', '10.04.1993', 'Kardiyoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(59, '51394695990', 'Tugba', 'Yıldız', 'Temel', 'Bilecik', '10.04.1992', 'Kardiyoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(60, '73136921068', 'Mehmet', 'Aksoy', 'Kadir', 'Kahramanmaraş', '10.04.1991', 'Kulak Burun Boğaz (KBB)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(61, '36836579434', 'Ömer ', 'Işık', 'Osman', 'Trabzon', '10.04.1990', 'Kulak Burun Boğaz (KBB)', '(111) 111-1111', 'test@localhost', '123123', '1'),
(62, '12013615324', 'Caner', 'Kurt', 'Hasan', 'Trabzon', '10.04.1991', 'Nefroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(63, '12749443284', 'Hanife ', 'Aslan', 'Onur', 'Erzincan', '10.04.1992', 'Nefroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(64, '82293490096', 'Onur', 'Özer', 'Kemal', 'Zonguldak', '10.04.1995', 'Nöroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(65, '31411705956', 'Rabia', 'Yılmaz', 'Kadir', 'Osmaniye', '10.05.1990', 'Nöroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(66, '86607561144', 'Hüseyin', 'Taş', 'Hasan', 'Yozgat', '11.02.1992', 'Ortodonti', '(111) 111-1111', 'test@localhost', '123123', '1'),
(67, '53899984746', 'Furkan', 'Özkan', 'İsmet', 'Niğde', '11.02.1993', 'Ortodonti', '(111) 111-1111', 'test@localhost', '123123', '1'),
(68, '45101546422', 'Süleyman ', 'Aslan', 'Muhammed', 'Bilecik', '11.02.1994', 'Ortopedi ve Travmatoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(69, '33459689298', 'Nisa', 'Şimşek', 'Erdem', 'Afyonkarahisar', '11.02.1992', 'Ortopedi ve Travmatoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(70, '33058804900', 'Can', 'Aşık', 'Temp', 'Mersin', '01.01.1999', 'Psikoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(72, '92741055586', 'Rüya ', 'Gül', 'Polat', 'Adıyaman', '11.02.1994', 'Psikoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(73, '38758715082', 'Batuhan', 'Turan', 'Kemal', 'Ankara', '11.02.1992', 'Radyoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(74, '16709078806', 'Azra', 'Aksoy', 'Hakan', 'Rize', '11.02.1995', 'Radyoloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(75, '56967782404', 'Enes ', 'Yüksel', 'İsmail', 'Ankara', '11.02.1996', 'Tıbbi Laboratuvar', '(111) 111-1111', 'test@localhost', '123123', '1'),
(76, '65683632986', 'Ceren', 'Şimşek', 'Hasan', 'Rize', '11.02.1992', 'Tıbbi Laboratuvar', '(111) 111-1111', 'test@localhost', '123123', '1'),
(77, '55850925706', 'Kemal', 'Can', 'Rüstem', 'Ağrı', '11.02.1980', 'Üroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(78, '65552794036', 'Burak', 'Kılıç', 'Samet', 'Ankara', '11.02.1978', 'Üroloji', '(111) 111-1111', 'test@localhost', '123123', '1'),
(79, '40982867116', 'Betül ', 'Turan', 'Kemal', 'Denizli', '11.02.1976', 'Yenidoğan Yoğun Bakım', '(111) 111-1111', 'test@localhost', '123123', '1'),
(80, '32200235906', 'Ela', 'Bozkur', 'Can', 'Ankara', '11.02.1973', 'Yenidoğan Yoğun Bakım', '(111) 111-1111', 'test@localhost', '123123', '1');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `date`
--
ALTER TABLE `date`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `recete`
--
ALTER TABLE `recete`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `sickusers`
--
ALTER TABLE `sickusers`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `tckn` (`tckn`) USING HASH;

--
-- Tablo için indeksler `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `branch`
--
ALTER TABLE `branch`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- Tablo için AUTO_INCREMENT değeri `date`
--
ALTER TABLE `date`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;

--
-- Tablo için AUTO_INCREMENT değeri `recete`
--
ALTER TABLE `recete`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `sickusers`
--
ALTER TABLE `sickusers`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Tablo için AUTO_INCREMENT değeri `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
