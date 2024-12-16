using Mediator_Pattern_Chat;


namespace ChatSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator chatMediator = new ChatMediator();

            User user1 = new User("Денис", chatMediator);
            User user2 = new User("Егойчик", chatMediator);
            User user3 = new User("Абоб", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Бобр курва!", "Егойчик");
            user2.SendMessage("Я пердоле!", "Денис");
            user3.SendMessage("Когда спать?", "Егойчик");

            Console.WriteLine();
            chatMediator.ShowMessageHistory("Денис");
            Console.WriteLine();
            chatMediator.ShowMessageHistory("Егойчик");
            Console.WriteLine();
            chatMediator.ShowMessageHistory("Абоба");

            Console.WriteLine();
            chatMediator.RemoveUser("Абоба");
        }
    }
}