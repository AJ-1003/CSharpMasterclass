namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 1");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 4");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 5");
            //Console.WriteLine();

            //var thread1 = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number 1: {Thread.CurrentThread.ManagedThreadId} started!");
            //    Thread.Sleep(1500);
            //    Console.WriteLine("Hello, World! New Thread 1");
            //    Console.WriteLine($"Thread number 1: {Thread.CurrentThread.ManagedThreadId} ended!");
            //    Console.WriteLine();
            //});
            //var thread2 = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number 2: {Thread.CurrentThread.ManagedThreadId} started!");
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Hello, World! New Thread 2");
            //    Console.WriteLine($"Thread number 2: {Thread.CurrentThread.ManagedThreadId} ended!");
            //    Console.WriteLine();

            //});
            //var thread3 = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number 3: {Thread.CurrentThread.ManagedThreadId} started!");
            //    Thread.Sleep(2500);
            //    Console.WriteLine("Hello, World! New Thread 3");
            //    Console.WriteLine($"Thread number 3: {Thread.CurrentThread.ManagedThreadId} ended!");
            //    Console.WriteLine();

            //});
            //var thread4 = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number 4: {Thread.CurrentThread.ManagedThreadId} started!");
            //    Thread.Sleep(3000);
            //    Console.WriteLine("Hello, World! New Thread 4");
            //    Console.WriteLine($"Thread number 4: {Thread.CurrentThread.ManagedThreadId} ended!");
            //    Console.WriteLine();

            //});
            //var thread5 = new Thread(() =>
            //{
            //    Console.WriteLine($"Thread number 5: {Thread.CurrentThread.ManagedThreadId} started!");
            //    Thread.Sleep(3500);
            //    Console.WriteLine("Hello, World! New Thread 5");
            //    Console.WriteLine($"Thread number 5: {Thread.CurrentThread.ManagedThreadId} ended!");
            //});

            //var taskCompletionSource = new TaskCompletionSource<bool>();

            //var thread = new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    taskCompletionSource.TrySetResult(true);
            //});
            //Console.WriteLine();
            //Console.WriteLine($"Thread number: {thread.ManagedThreadId}");
            //Console.WriteLine();
            //Console.WriteLine($"Thread 1 number: {thread1.ManagedThreadId}");
            //Console.WriteLine();
            //Console.WriteLine($"Thread 2 number: {thread2.ManagedThreadId}");
            //Console.WriteLine();
            //Console.WriteLine($"Thread 3 number: {thread3.ManagedThreadId}");
            //Console.WriteLine();
            //Console.WriteLine($"Thread 4 number: {thread4.ManagedThreadId}");
            //Console.WriteLine();
            //Console.WriteLine($"Thread 5 number: {thread5.ManagedThreadId}");
            //Console.WriteLine();
            //thread.Start();
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            //thread4.Start();
            //thread5.Start();

            //var test = taskCompletionSource.Task.Result;

            //Console.WriteLine("-----------------------");
            //Console.WriteLine($"Task completed: {test}");
            //Console.WriteLine("-----------------------");

            //Console.WriteLine("=================< FIRST SECTION DONE >=================");

            //new Thread(() =>
            //{
            //    Console.WriteLine($"Background thread number {Thread.CurrentThread.ManagedThreadId} started");
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"Background thread number {Thread.CurrentThread.ManagedThreadId} ended");
            //})
            //{
            //    IsBackground = true
            //}.Start();

            //Console.WriteLine();

            //Enumerable.Range(0, 1000).ToList().ForEach(t =>
            //{
            //    ThreadPool.QueueUserWorkItem((o) =>
            //    {
            //        Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} started");
            //        Thread.Sleep(1000);
            //        Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} ended");
            //    });
            //    //new Thread(() =>
            //    //{
            //    //    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} started");
            //    //    Thread.Sleep(1000);
            //    //    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} ended");
            //    //}).Start();
            //});

            Console.WriteLine("=================< SECOND SECTION DONE >=================");

            Console.WriteLine("Main thread started!");

            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);

            thread1.Start();
            thread2.Start();

            //thread1.Join();
            //Console.WriteLine("Thread 1 Function Joined!");

            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread 1 Function Done!");
            }
            else
            {
                Console.WriteLine("Thread 1 Function wasn't done within  1 second!");
            }
            thread2.Join();
            Console.WriteLine("Thread 2 Function Joined!");

            for (var i = 0; i < 10; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread 1 is still doing stuff!");
                }
                else
                {
                    Console.WriteLine("Thread 1 is completed with all its tasks!");
                }
            }

            Console.WriteLine("Main thread ended!");

            Console.ReadKey();
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread 1 Function started!");
            Thread.Sleep(3000);
            Console.WriteLine("Thread 1 Function is returning to caller!");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread 2 Function started!");
            Thread.Sleep(1000);
        }
    }
}