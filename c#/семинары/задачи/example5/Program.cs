Console.Write("введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == " миша")
{
    Console.WriteLine("Рад приветствовать Вас мой господин");
}
else
{
    Console.Write("Инормация скрыта");
    Console.WriteLine(username);
}