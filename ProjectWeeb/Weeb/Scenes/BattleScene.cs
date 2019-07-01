using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weeb.Models;

namespace Weeb.Scenes
{
    class BattleScene : IScene
    {
        public List<ICharacter> Heroes { get; set; }

        public List<ICharacter> Enemies { get; set; }
        public List<ICharacter> ActionList { get; set; }
        private Int32 Round { get; set; }

        public BattleScene(List<ICharacter> heroes, List<ICharacter>enemies)
        {
            Heroes = heroes;
            Enemies = enemies;
            ActionList = new List<ICharacter> { };
            foreach (ICharacter hero in heroes)
                hero.ActionFlag = true;
            foreach (ICharacter enemy in enemies)
                enemy.ActionFlag = true;
            Round = 0;
        }

        public void LoadScene()
        {
            // Loop until all charactors on one side are dead
            while (true)
            {
                // Turn Loop
                while (ActionList.Count>0)
                {
                    DisplayBattleGround();
                    ICharacter currentMove = CharacterToAct();
                    Console.WriteLine("{0}'s turn to act.", currentMove.Name);
                    Console.ReadKey();
                    
                    ActionList.Remove(currentMove);
                }
            }
        }
        private void DisplayBattleGround()
        {
            Game.Refresh();
            int maxCount = Math.Max(Heroes.Count, Enemies.Count);
            int minCount = Math.Min(Heroes.Count, Enemies.Count);
            for(int i=0; i<maxCount; i++)
            {
                if (i < minCount)
                {
                    for (int j=0; j<Heroes[i].BattleInfo().Count();j++)
                    {
                        Console.WriteLine("{0}{1,65}", Heroes[i].BattleInfo()[j], Enemies[i].BattleInfo()[j]);
                     }
                }
                else if (i>= Heroes.Count)
                {
                    for (int j = 0; j < Enemies[i].BattleInfo().Count(); j++)
                    {
                        if (j == 0 || j == Enemies[i].BattleInfo().Count()-1)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("{0,76}", Enemies[i].BattleInfo()[j]);
                    }
                }
                else if(i>= Enemies.Count)
                {
                    for (int j = 0; j < Heroes[i].BattleInfo().Count(); j++)
                    {
                        Console.WriteLine("{0}", Heroes[i].BattleInfo()[j]);
                    }
                }
            }
            Console.ReadKey();
        }
        private ICharacter CharacterToAct()
        {
            foreach (ICharacter hero in Heroes)
            {
                if (hero.HealthPoints > 0 && hero.ActionFlag == true)
                {
                    ActionList.Add(hero);
                }
            }
            foreach (ICharacter enemy in Enemies)
            {
                if (enemy.HealthPoints > 0 && enemy.ActionFlag == true)
                {
                    ActionList.Add(enemy);
                }
            }
            return ActionList.OrderByDescending(c => c.Agility).FirstOrDefault();
        }
        private void SetUpTurn()
        {

        }
    }
}
