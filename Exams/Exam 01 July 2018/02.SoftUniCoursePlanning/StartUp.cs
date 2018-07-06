using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniCoursePlanning
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> startingProgram = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            var commandInput = Console.ReadLine();

            while (commandInput!= "course start")
            {
                var commandArgs = commandInput.Split(':').ToArray();
                var command = commandArgs[0];


                switch (command)
                {
                    case "Add":
                        AddLesson(commandArgs,startingProgram);
                        break;
                    case "Insert":
                        InsertLesson(commandArgs, startingProgram);
                        break;
                    case "Remove":
                        RemoveLessonAndExercise(commandArgs, startingProgram);
                        break;
                    case "Swap":
                        SwapLessons(commandArgs, startingProgram);
                        break;
                    case "Exercise":
                        AddExercise(commandArgs, startingProgram);
                        break;
                    default:
                        break;
                }
                commandInput = Console.ReadLine();
            }
            for (int i = 0; i < startingProgram.Count; i++)
            {
                Console.WriteLine($"{i+1}.{startingProgram[i]}");
            }
                    
        }

        private static void AddExercise(string[] commandArgs, List<string> startingProgram)
        {
            var lesson = commandArgs[1];
            var exercise = commandArgs[1] + "-Exercise";

            if (startingProgram.Contains(lesson))
            {
                int index = startingProgram.IndexOf(lesson);
                if (!startingProgram.Contains(exercise))
                {
                    startingProgram.Insert(index + 1, exercise);
                }
            }
            else
            {
                startingProgram.Add(lesson);
                startingProgram.Add(exercise);
            }
        }

        private static void SwapLessons(string[] commandArgs, List<string> startingProgram)
        {
            var firstLesson= commandArgs[1];
            var secondLesson = commandArgs[2];

            if (!startingProgram.Contains(firstLesson))
            {
                return;
            }
            if (!startingProgram.Contains(secondLesson))
            {
                return;
            }
            var indexOne = startingProgram.IndexOf(firstLesson);
            var indexTwo = startingProgram.IndexOf(secondLesson);

            if (startingProgram.IndexOf(firstLesson)>startingProgram.IndexOf(secondLesson))
            {

                RearrengeProgram(indexTwo, secondLesson, indexOne, firstLesson,startingProgram);
            }
            else
            {
               RearrengeProgram(indexOne, firstLesson, indexTwo, secondLesson,startingProgram);
            }
            
        }

        private static void RearrengeProgram(int firstIndex, string firstLesson, int secondIndex, string secondLesson,List<string> program)
        {
            var newProgram = new List<string>();
            var exerciseOne =  firstLesson + "-Exercise";
            var exerciseTwo =  secondLesson + "-Exercise";
            bool hasExerciseOne = program.Contains(exerciseOne);
            bool hasExrciseTwo = program.Contains(exerciseTwo);

            if (hasExerciseOne && hasExrciseTwo)
            {
                program.RemoveAt(secondIndex);
                program.RemoveAt(secondIndex);
                program.RemoveAt(firstIndex);
                program.RemoveAt(firstIndex);

                program.Insert(firstIndex, secondLesson);
                program.Insert(firstIndex+1, exerciseTwo);
                program.Insert(secondIndex, firstLesson);
                program.Insert(secondIndex + 1, exerciseTwo);
            }
            else if (hasExerciseOne == false && hasExrciseTwo)
            {
                program.RemoveAt(secondIndex);
                program.RemoveAt(secondIndex);
                program.RemoveAt(firstIndex);

                program.Insert(firstIndex, secondLesson);
                program.Insert(firstIndex + 1, exerciseTwo);
                program.Insert(secondIndex + 1, firstLesson);
            }
            else if (hasExerciseOne && hasExrciseTwo == false)
            {
                program.RemoveAt(secondIndex);
                program.RemoveAt(firstIndex);
                program.RemoveAt(firstIndex);

                program.Insert(firstIndex, secondLesson);
                program.Insert(firstIndex+1, exerciseTwo);
                program.Insert(secondIndex + 1, firstLesson);
            }
            else
            {
                program.RemoveAt(secondIndex);
                program.RemoveAt(firstIndex);

                program.Insert(firstIndex, secondLesson);
                program.Insert(secondIndex, firstLesson);
            }

        }

        private static void RemoveLessonAndExercise(string[] commandArgs, List<string> startingProgram)
        {

            var lessonToRemove = commandArgs[1];
            var exercise = commandArgs[1] + "-Exercise";
            if (startingProgram.Contains(lessonToRemove))
            {
                startingProgram.Remove(lessonToRemove);
                if (startingProgram.Contains(exercise))
                {
                    startingProgram.Remove(exercise);
                }
            }
        }

        private static void InsertLesson(string[] commandArgs, List<string> startingProgram)
        {
            var lessonToInsert = commandArgs[1];
            var index = int.Parse(commandArgs[2]);
            if (startingProgram.Contains(lessonToInsert))
            {
                return;
            }
            if (!startingProgram.Contains(lessonToInsert) && (index>=0 && index<startingProgram.Count))
            {
                startingProgram.Insert(index, lessonToInsert);
            }
        }

        private static void AddLesson(string[] commandArgs,List<string> program)
        {
            var lessonToAdd = commandArgs[1];
            if (!program.Contains(lessonToAdd))
            {
                program.Add(lessonToAdd);
            }
        }
    }
}
