(double temp, string unit) FahTOCel(float C){
float Apt1 = C-32;
double answer = Apt1 * 0.5555555556;
Console.WriteLine($"{C} fahrenheit is {answer:00.00} Celsius");
Console.ReadKey();
return (answer, "celsius") ;
}

(double temp, string unit) FahTOKel(float C){
float Apt1 = C-32;
double answer = Apt1 * 0.5555555556;
double answer2 = answer + 273.372;
Math.Round(answer2);
Console.WriteLine($"{C} fahrenheit is {answer2:00.00} Kelvin" );
Console.ReadKey();
return (answer, "kelvin") ;
}

(double temp, string unit) CelTOFah(double C){
double answer = C * 1.8;
double Apt1 = answer+32;
Math.Round(Apt1);
Console.WriteLine($"{C} Celsius is {Apt1:00.00} Fahrenheit" );
Console.ReadKey();
return (answer, "celsius") ;
}

(double temp, string unit) CelTOKel(double C){
double Apt1 = C+273.15;
Math.Round(Apt1);
Console.WriteLine($"{C} Celsius is {Apt1:00.00} Kelvin" );
Console.ReadKey();
return (Apt1, "celsius") ;
}

(double temp, string unit) KelTOFah(double C){
double Apt1 = C - 273.15;
double Apt2 = Apt1 * 1.8;
double answer = Apt2 +32;
Math.Round(answer, 00.00);
Console.WriteLine($"{C} Kelvin is {answer:00.00} Fahrenheit" );
Console.ReadKey();
return (answer, "celsius") ;
}

(double temp, string unit) KelTOCel(double C){
double Apt1 = C-273.15;
Math.Round(Apt1);
Console.WriteLine($"{C} Celsius is {Apt1:00.00} Kelvin" );
Console.ReadKey();
return (Apt1, "celsius") ;
}

(double length, string unit) InchTOFoot(double measure){
double Apt1 = measure/12;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{measure} Inches is 1 Foot");
}
else {
Console.WriteLine($"{measure} Inches is {Apt1:00.00} Feet" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double length, string unit) InchTOYard(double measure){
double Apt1 = measure/36;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{measure} Inches is 1 Yard");
}
else {
Console.WriteLine($"{measure} Inches is {Apt1:00.00} Yards" );
}
Console.ReadKey();
return (Apt1, "Yerad") ;
}

(double length, string unit) FootTOInch(double measure){
double Apt1 = measure*12;
Math.Round(Apt1);
if (measure == 1)
{
    Console.WriteLine($"{measure} Foot is 12 Inches");
}
else {
Console.WriteLine($"{measure} Feet is {Apt1:00.00} Inches" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double length, string unit) FootTOYard(double measure){
double Apt1 = measure/3;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{measure} Feet is 1 Yard");
}
else if (measure==1){
    Console.WriteLine($"{measure} Foot is {Apt1} Yards");
}
else {
Console.WriteLine($"{measure} Feet is {Apt1:00.00} Yards" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double length, string unit) YardTOInch(double measure){
double Apt1 = measure*36;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{measure} yard is 36 Inches");
}
else {
Console.WriteLine($"{measure} Yards is {Apt1:00.00} Inches" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double length, string unit) YardTOfoot(double measure){
double Apt1 = measure*3;
Math.Round(Apt1);
if (measure == 1)
{
    Console.WriteLine($"{measure} Yard is 3 Feet");
}
else {
Console.WriteLine($"{measure} Yards is {Apt1:00.00} Feet" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double time, string unit) SecondsTOMinutes(double T){
double Apt1 = T/60;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{T} Seconds is 1 Minute");
}
else {
Console.WriteLine($"{T} Seconds is {Apt1:00.00} minutes" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double time, string unit) SecondsTOHours(double T){
double Apt1 = T/3600;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{T} Seconds is 1 hour");
}
else {
Console.WriteLine($"{T} Seconds is {Apt1:00.00} Hours" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double time, string unit) MinutesTOSeconds(double T){
double Apt1 = T*60;
Math.Round(Apt1);
Console.WriteLine($"{T} Seconds is {Apt1:00.00} minutes" );
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double time, string unit) MinutesTOHours(double T){
double Apt1 = T/60;
Math.Round(Apt1);
if (Apt1 == 1)
{
    Console.WriteLine($"{T} Minutes is 1 Hour");
}
else {
Console.WriteLine($"{T} Minutes is {Apt1:00.00} Hours" );
}
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double time, string unit) HoursTOSeconds(double T){
double Apt1 = T*3600;
Math.Round(Apt1);
Console.WriteLine($"{T} Hours is {Apt1:00.00} Seconds" );
Console.ReadKey();
return (Apt1, "FOOT") ;
}

(double time, string unit) HoursTOMinutes(double T){
double Apt1 = T*60;
Math.Round(Apt1);
Console.WriteLine($"{T} Hours is {Apt1:00.00} Minutes" );
Console.ReadKey();
return (Apt1, "FOOT") ;
}
bool superending = true;
while (superending){
Console.Clear();
Console.WriteLine("Welcome to CONVERTOTRON 5001!\n What would you like to convert?");
Console.WriteLine("(1) Tempratures \n(2) Distance \n(3) Time\n(4) leave ");
int firstChoice = int.Parse(Console.ReadLine());
switch (firstChoice){
    case 1:
    Tempratures();
    break;
    case 2:
    Length();
    break;
    case 3:
    Time();
    break;
    case 4:
    Console.WriteLine("GoodBye");
    superending=false;
    break;

}
}
void Tempratures(){
int userInput=0;
Console.WriteLine("What is the temrature you want to convert?");
userInput = int.Parse(Console.ReadLine());
Console.WriteLine("What is the unit?");
Console.WriteLine("(1)Fahrenheit\n(2) Celsius\n(3) Kelvin\n");
int tempChoice = int.Parse(Console.ReadLine());
switch (tempChoice){
    case 1:
    //Fahrenheit
    Fahrenheitconvo(userInput);
    break;
    case 2:
    //Celsius
    celsiusConvo(userInput);
    break;
    case 3:
    //Kelvin
    kelvinConvo(userInput);
    break;
}
}
// User conversion functions Temprature
void Fahrenheitconvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Celsius\n(2) Kelvin"); 
int fahChoice = int.Parse(Console.ReadLine());
switch (fahChoice){
    case 1:
    FahTOCel(X);
    break;
    case 2:
    FahTOKel(X);
    break;
}
}
void celsiusConvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Fahrenheit\n(2) Kelvin"); 
int celChoice = int.Parse(Console.ReadLine());
switch (celChoice){
    case 1:
    CelTOFah(X);
    break;
    case 2:
    CelTOKel(X);
    break;
}
}
void kelvinConvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Fahrenheit\n(2) Celsius"); 
int fahChoice = int.Parse(Console.ReadLine());
switch (fahChoice){
    case 1:
    KelTOFah(X);
    break;
    case 2:
    KelTOCel(X);
    break;
}
}


void Length(){
int userInput=0;
Console.WriteLine("What is the Length you want to convert?");
userInput = int.Parse(Console.ReadLine());
Console.WriteLine("What is the unit?");
Console.WriteLine("(1) Inches\n (2) Feet\n (3) yards");
int tempChoice = int.Parse(Console.ReadLine());
switch (tempChoice){
    case 1:
    //INCHES
    Inchesconvo(userInput);
    break;
    case 2:
    //FOOT
    feetConvo(userInput);
    break;
    case 3:
    //YARD
    yardConvo(userInput);
    break;
    
}
}
// User conversion functions for distance
void Inchesconvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Feet\n(2) Yards"); 
int inChoice = int.Parse(Console.ReadLine());
switch (inChoice){
    case 1:
    InchTOFoot(X);
    break;
    case 2:
    InchTOYard(X);
    break;
}
}
void feetConvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Inches\n(2) Yards"); 
int celChoice = int.Parse(Console.ReadLine());
switch (celChoice){
    case 1:
    FootTOInch(X);
    break;
    case 2:
    FootTOYard(X);
    break;
}
}
void yardConvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Inches\n(2) Feet"); 
int fahChoice = int.Parse(Console.ReadLine());
switch (fahChoice){
    case 1:
    YardTOInch(X);
    break;
    case 2:
    YardTOfoot(X);
    break;
}
}

void Time(){
int userInput=0;
Console.WriteLine("What is the time you want to convert?");
userInput = int.Parse(Console.ReadLine());
Console.WriteLine("What is the unit?");
Console.WriteLine("(1) Seconds\n (2) Minutes\n (3) Hours");
int tempChoice = int.Parse(Console.ReadLine());
switch (tempChoice){
    case 1:
    //Fahrenheit
    Secondsconvo(userInput);
    break;
    case 2:
    //Celsius
    minutesConvo(userInput);
    break;
    case 3:
    //Kelvin
    hoursConvo(userInput);
    break;
    case 4:
    //back to start
    break;
}
}
// User conversion functions for time
void Secondsconvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Minutes\n(2) Hours"); 
int fahChoice = int.Parse(Console.ReadLine());
switch (fahChoice){
    case 1:
    SecondsTOMinutes(X);
    break;
    case 2:
    SecondsTOHours(X);
    break;
}
}
void minutesConvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Second\n(2) Hours"); 
int celChoice = int.Parse(Console.ReadLine());
switch (celChoice){
    case 1:
    MinutesTOSeconds(X);
    break;
    case 2:
    MinutesTOHours(X);
    break;
}
}
void hoursConvo(int X){
Console.WriteLine("what are you converting to?");
Console.WriteLine("(1) Seconds\n(2) Minutes"); 
int fahChoice = int.Parse(Console.ReadLine());
switch (fahChoice){
    case 1:
    HoursTOSeconds(X);
    break;
    case 2:
    HoursTOMinutes(X);
    break;
}
}

enum tempratures  {Celsius, Fahrenheit, Kelvin};
enum length {inch, feet, yard};
enum time {seconds, minutes, hours};
enum conversions {tempratures, length, Time};
