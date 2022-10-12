﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PET_PROJECT___RESTAURANT_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {

            string menuJsonData = File.ReadAllText("C:\\Users\\mjugoo\\source\\repos\\PET PROJECT - RESTAURANT CONSOLE\\PET PROJECT - RESTAURANT CONSOLE\\menu.json");
            //deserialize json into list
            var menuList = JsonSerializer.Deserialize<List<Menu_list>>(menuJsonData);

            //check if menu list is null 
            if (menuList != null)
            {


                foreach (var menu in menuList)
                {

                    //String interpolation - Inject object into string
                    Console.WriteLine($"{menu.mealName} {menu.price}");

                }
            }
            //Console.WriteLine(menuJsonData);
            Console.Read();












        }

    }

}


