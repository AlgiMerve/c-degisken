int deger =2;
string degisken =null;
string Değisken =null;
//string class=null; burada 'class' özel isim olduğu için değişken olarak kabul edilmez.
//string 3degisken=null; şeklinde tanımlanamaz çünkü değişken isimleri rakam ile başlayamaz.
// string degisken+veri=null; şeklinde tanımlama yapılamaz çünkü değişeken tanımlanırken matematiksel
// operatör kullanılamaz.
byte b =5;//1 byte yer kaplar
sbyte c =5; //1 byte yer kaplar
short s =5;//2 byte yer kaplar
ushort us=5;//2 byte yer kaplar
Int16 i16=5;//2byte yer kaplar
int i=5;//4 byte yer kaplar
Int32 i32=5;//4 byte yer kaplar
Int64 i64=5;//8 byte yer kaplar
uint u1=2;//4 byte yer kaplar
ulong ul=5;//8 byte yer kaplar
long l=6;//8 byte yer kaplar
float f=8;//4 byte yer kaplar
double d=5;//8 byte yer kaplar
decimal de=5;//16 byte yer kaplar
char ch ='2';//2 byte yer kaplar
string str="merve";//sınırsız yer kaplar
bool b1=true;
bool b2=false;
DateTime dt=DateTime.Now;
object o1="x";
object o2='y';
object o3=3;
object o4=4.3;
string strl=string.Empty;
strl="merve ALGI";
string ad="merve";
string soyad="ALGI";
string tamisim=ad + " " + soyad;
int intdeger1=5;
int intdeger2=3;
int intdeger3=intdeger1+intdeger2;
Console.WriteLine(intdeger3);
bool bool1=10>2;
string str20="20";
int  int20=20;
string yenideger=str20 + int20.ToString();
int int21=int20 + Convert.ToInt32(str20);
Console.WriteLine(int21);
int int22=int20 + int.Parse(str20);
Console.WriteLine(int22);
string datetime=DateTime.Now.ToString("dd.mm.yyyy");
Console.WriteLine(datetime);
string hour=DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour);
Console.WriteLine(dt);
Console.WriteLine(deger);
Console.ReadKey();// "console": "externalTerminal" kullandım bu yüzden 
// çıktıyı ekranda daha rahat görebilmek için ekledim.

