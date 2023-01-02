// See https://aka.ms/new-console-template for more information

using UsingYapısı;

using UsingDeneme usingDeneme = new UsingDeneme();
Sum();
void Sum()
{
    using UsingDeneme usingDeneme1 = new UsingDeneme();
    usingDeneme1.Show();
}

UsingDeneme GenerateMetot()
{
    using UsingDeneme deneme = new UsingDeneme();
    return deneme;
}
using UsingDeneme deneme2 = GenerateMetot();
deneme2.Show();