# 🎯 Number Guessing Game

A fun and interactive **console-based number guessing game** built with **.NET (C#)**.

---

## 🕹️ Overview

This simple **CLI game** challenges you to guess the number that the computer has secretly chosen between **1 and 100**.  
You’ll need to use your limited attempts wisely based on your chosen **difficulty level** — and watch for clues when your guess is too high or too low.

---

## ⚙️ How It Works

When you launch the app, you’ll first see the **game rules** displayed on the screen:

1. The **computer** will choose a random number between **1 and 100**.  
2. You have a **limited number of chances** to guess the correct number.  
3. After each guess, the app will tell you whether the number is **higher** or **lower** than your guess.  
4. The number of attempts depends on the **difficulty level** you choose.  

---

## 💪 Difficulty Levels

| Level | Name | Attempts |
|:------:|:-----|:----------:|
| 1 | Easy | 🎯 10 attempts |
| 2 | Medium | 🎯 5 attempts |
| 3 | Hard | 🎯 3 attempts |

---

## 🔍 Input Validation

- You **must** enter a valid number between **1–100** when guessing.  
- If you enter an invalid input (like a letter or symbol), the app will show **“Invalid input”** and prompt you again.  
- When typing **restart** or **exit**, the app will ask for confirmation (`y/n`) before taking action.

---

## 🧩 Project Structure

```
NumberGuessingGame/
│
├── Program.cs     # Main logic, user interaction, and game flow
├── Computer.cs    # Random number generation logic
└── README.md      # Project documentation
```

---

## ▶️ How to Play

1. Run the app using:
   ```bash
   dotnet run
   ```
2. Read the game instructions displayed in the console
3. Choose a **difficulty level** by entering `1`, `2`, or `3`.  
4. Enter your guesses — the app will guide you by saying if the number is **higher** or **lower**.  
5. You win if you guess correctly before running out of attempts! 🎉  
6. Type `exit` anytime to quit the game (you’ll be asked to confirm).

---

## 💡 Future Improvements that might be added

- Add a **scoreboard** for wins/losses  
- Add **timer-based** challenge mode  
- Add **colorful console output** for better user experience  
- Save user statistics to a file  

