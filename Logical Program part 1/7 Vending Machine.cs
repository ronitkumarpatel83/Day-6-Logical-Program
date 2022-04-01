using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program_part_1
{
    internal class VendingMachine
    {
        public void CountMoney()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 }; //Creating notes array
            Console.WriteLine("Enter amount : ");
            int money = Convert.ToInt32(Console.ReadLine()); // reads the rupees 
            int j = 0;
            int rs = money;
            int[] notesFrequency = { 0, 0, 0, 0, 0, 0, 0, 0 };// Creating array to count frequency of notes
            bool is_start = true;
            while (true)
            {
                for (int i = 0; i < notes.Length; i++) // This loops will continue till Lenth of array
                {
                    if (rs > notes[i] || (rs == notes[i] && !is_start)) // This condition will find notes highest value having
                    {                                                   // less value than Rupees entered by user
                        j = i;
                        break;
                    }
                }
                rs = rs - notes[j];//Sum= track this smaller note value from Rupee 
                notesFrequency[j] += 1; // Which notes value extracted from rupees that notes frequency increased by 1
                if (rs == 0) // If rupees zero then break
                {
                    break;
                }
                is_start = false;
            }
            for (int i = 0; i < notesFrequency.Length; i++)
            {
                Console.WriteLine($"Frequency of {notes[i]} rupees note : {notesFrequency[i]}");
            }
        }
    }
}
