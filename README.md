# fitness-center-manager
Project made for the subject specification of software systems

## Short synopsis

A fitness center :
- There are 3 types of users: Administrator, Trainer and Client
- You can register as a trainer or client while the administrators are registered directly through a MicrosoftSQL database
- If you register as a trainer you have to provide a certificate file that is checked by the administrator and if everything is correct your account is made
- Clients have the option to choose a training plan and the trainer of their choice and if the trainer wants to do the training they approve the session
- Each training session can be canceled before the training starts
- The training session is displayed with a imaginary timer that counts down 60 seconds, when the animation is completed the training is over
- At the end of each training session both client and trainer are given a prompt to rate each other
- All entities, users and files are saved in the database

## Tools used for the project
- The project is written in C#
- Front end is made with Windows Forms
- .NET Framework
- NuGet packages
- MicrosoftSQL
