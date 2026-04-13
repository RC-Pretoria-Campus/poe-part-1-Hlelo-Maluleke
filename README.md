[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/N9ZZCjXE)

 PSEUDOCODE 
 - Display ASCII art using ASCII class.
 - Prompt user for name.
 - Use a nullable string variable (userName = null) to hold name input while validating.
 - Loop until a non-empty, non-whitespace name is entered:
    - Read a line from Console and call .ToUpper() to normalize, then store in userName.
    - If userName is null or whitespace, show an error and continue the loop.
    - When valid name is entered, exit the loop.
 - Greet the user with the validated userName.
 - Enter the main chat loop:
    - Display colored prompt with the username.
    - Read user input from Console and convert to lowercase.
    - Get response from ResponseSys.UserResponse() method.
    - Check if user typed "exit" to break out of loop.
    - Display response using ResponseSys.PrintWithTypingEffect() for typewriter effect.
    - Reset console color and repeat until user exits.

<img width="1879" height="627" alt="Screenshot 2026-04-13 195301" src="https://github.com/user-attachments/assets/b16e2696-181a-44f3-aedb-4cc069d08131" />
