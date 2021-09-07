- 👋 Hi, I’m @Edvarc
- 👀 I’m interested in maps, bees, velo...
- 🌱 I’m currently learning sii sharp...
- 💞️ I’m looking to collaborate on ...
- 📫 How to reach me ...

<!---
Edvarc/Edvarc is a ✨ special ✨ repository because its `README.md` (this file) appears on your GitHub profile.
You can click the Preview link to take a look at your changes.
--->
Helloo
tests
Edvarts testē - šo ierakstu iekš Studio

tests 7 sept 

Int16.Parse("100"); // returns 100
Int16.Parse("(100)", NumberStyles.AllowParentheses); // returns -100

int.Parse("30,000", NumberStyles.AllowThousands, new CultureInfo("en-au"));// returns 30000
int.Parse("$ 10000", NumberStyles.AllowCurrencySymbol); //returns 10000
int.Parse("-100", NumberStyles.AllowLeadingSign); // returns -100
int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite); // returns 100

Int64.Parse("2147483649"); // returns 2147483649