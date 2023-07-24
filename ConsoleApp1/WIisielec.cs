using System;

namespace WisielecGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hangmanImages = {
                @"
  +---+
  |   |
      |
      |
      |
      |
=========",
                @"
  +---+
  |   |
  O   |
      |
      |
      |
=========",
                @"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
                @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
                @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
                @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
                @"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
            };
