namespace MaartenBalliauw.HelloWorld
{
    pxublic class Greeter
    {
        public string Greet(string name)
        {
            return string.Format("Hello, {0}!", name);
        }
        
        public string GreetFormal(string title, string name)
        {
            return string.Format("Hello, {0} {1}!", title, name);
        }
    }
}
