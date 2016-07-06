// Demo: Value Types

// Reference: https://msdn.microsoft.com/en-us/library/exx3b86w.aspx

int i = 0;          // implicit conversion, too, a.k.a. Int32
short sh = 32767;   // 2^16, or 32768, or +/- 0-32767, a.k.a. Int16
long l = 7;         // long int, 64-bit, a.k.a. Int64
byte by = 255;      // 2^8, or 256, or +/- 0-255, a.k.a. Byte
char c = 'i';       // a string is just a linked list of chars, note the single quotes, a.k.a. Char
bool b = false;     // 1 = true, 0 = false, a.k.a. Boolean
decimal p = 7.8m;    // 128-bit precision decimal, very expensive, a.k.a. Decimal
double d = 7.80;    // 64-bit decimal, a.k.a. Double
float f = 10.8f;    // floating point integer, must put f *explicit* conversion afterwards if using a constant, or you could cast as (float)
decimal dd = 7.80m; // must add the m if using a constant, or you could cast as (decimal)
int? ni = null;     // nullable variables, use .HasValue to determine if they are populated, useful with web services, database results

// Enumerations
// Based on an integral type (default: Int32)
// Essentially just labels associated with the base type; compiler will allow casting
enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

DayOfWeek day = DayOfWeek.Tuesday;

/* --------------------- */

// Demo: Reference Types

object o = null;

string s = "a string"; // up to 2 gigs in size, or 2^32 bytes, or Int32.MaxValue, a.k.a. String
string s2 = "This is a\r\n\tmulti-line string";
string s3 = @"This is a \r\n\tverbatim string";

Console.WriteLine(s);
Console.WriteLine(s2);
Console.WriteLine(s3);

/* --------------------- */

// Demo: Type Inference

var x = 0;
var sb = new System.Text.StringBuilder();
