using System;
using System.Runtime.CompilerServices;
using StackExchange.Redis;

namespace AzureRedisSubscriber
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Redis Message subscriber.");

         var redisClient = ConnectionMultiplexer.Connect("chyaredis.redis.cache.windows.net:6380,password=Q6UOzzdNSIiQa3sgw6znCeHINpfXKAStPkIEinjXths=,ssl=True,abortConnect=False");
         var redisSubscriber = redisClient.GetSubscriber();

         redisSubscriber.Subscribe("redisChannel", (x, y) =>
                                                   {
                                                      Console.WriteLine(y);
                                                   });

         Console.ReadKey();

      }
   }
}
