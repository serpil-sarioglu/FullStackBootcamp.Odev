using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public class Character
    {
        public delegate void HealthDecreasedEventHandler(int currentHealth);
        public event HealthDecreasedEventHandler HealthDecreased;

        public string CharacterName { get; set; }

        public int CharacterHealth { get; private set; }

        public Character(string characterName, int characterHealth)
        {
            CharacterName = characterName;
            CharacterHealth = characterHealth;
        }


        public void TakeDamage(int damage)
        {
            CharacterHealth -= damage;

            if (CharacterHealth < 0)
            {
                CharacterHealth = 0;
            }

            if (CharacterHealth == 0)
            {
                Console.WriteLine($"{CharacterName} karakteri öldü");
                return;
            }

            if (CharacterHealth < 20)
            {
                HealthDecreased.Invoke(CharacterHealth);
            }

        }

    }
}
