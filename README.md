![Logo](https://www.browserstack.com/images/static/header-logo.jpg)

# Manual To Automation @ Bupa - Lesson 1 - Practical Exercise <a href="https://specflow.org/"><img src="https://specflow.org/wp-content/uploads/2021/05/SpecFlow-Icon.png" alt="playwright" height="22" /></a>

## Introduction

This example code is an example of the a solution to the Exercise from Lesson 1. It contains 2 feature files and 2 test files to test those features. It serves as an introduction to automated testing and how to open a web page and interact with elements on that page.

---

## Installation

There are a few things that you will need before you can get started.

* Visual Studio for Windows / Mac - You can download this from [here](https://visualstudio.microsoft.com/downloads/). The page contains installers for Windows and Mac.
* Git for pulling down the code - follow [this](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git) guide for installing Git on all platforms. There are other useful guides on the website mentioned previously. Start [here](https://github.com/git-guides) anad follow through to the various links to learn more about Git. It will be very useful on your automation journey. If you have any issues with tokens or user credentials, let me know as this can trip a lot of people up.

Once you have these installed, you are good to go to the next step.

Follow the below steps to get the code onto your local machine.

* Open a terminal. (Terminal on Mac, Command Prompt on Windows)
* Go to the directory where you want to place the code using [cd](https://docs.microsoft.com/en-us/windows-server/administration/windows-commands/cd) for Windows, and it functions mostly the same for Mac. You just use "cd" but the folder structure on Mac is different (/Users/username/Documents instead of C:/Users/username/Documents)
* Copy the following command into the terminal, (remember, you must have [Git](https://git-scm.com/downloads) installed)
```sh
git clone https://github.com/Manual-To-Automation-Bupa/Bupa-Lesson-1-Exercise-Cleaner.git.
```
* Move into the directory that you just cloned by typing
```sh
cd Bupa-Lesson-1-Exercise-Cleaner
```
* Double click on the <b>Lesson1_Exercise_LoginAndVerify.sln</b> file to open the project in Visual Studio.

## Running the tests

To run the tests, you need to open the Test Explorer. You can do this by going to Windows -> Test Explorer. You can then click on the green triangle play button in order to run your tests. For more information on this, see [this](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2022) link.