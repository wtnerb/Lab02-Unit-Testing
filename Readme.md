# ATM in the Console
## Overview
This app simulates the behavior of an atm in the console. You can check your balance, withdraw money or even (though atms don't let you do this) deposit money.

## Use
Once compiled the app should be simple to run. You will need to press return at the end of each input. Don't add tabs or spaces to your input. Your balance will only display when specifically requested for security purposes. Attempting to depost/withdraw negative money and attempting to withdraw more money than you possess will throw exceptions that cause the transaction to fail without crashing the app. Same with attempting a transaction with a non-monetary value. The money input will trim whitespace if needed, but don't depend on that.

## Example
Starting view:
```
Which action would you like to take? +
1. View Balance
2. Deposit
3. Withdraw
4. Quit

```
To check your balance (which does have a default starting value) your input should be `1` and the `return` key. That will bring you to view the starting balance and ask for a keystroke to continue. At that point, just follow the prompts in the app.

## Architecture
The deposit, withdraw and view balance portions of the app utilize test driven development and the xunit package.

## Change log
2018-03-21 19:30 1.0 released as mvp plus a few bells and whistles.
A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.
<br />
Your job is to

1. tell them what it is (with context)
2. show them what it looks like in action
3. show them how they use it
4. tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

<br /> Refer to the sample-README in the class repo `Resources` folder for an example. 
- [Reference](https://github.com/noffle/art-of-readme)


## Rubric

- 7pts: Program meets all requirements described in Lab directions
- 3pts: Code meets industry standards
- **Readme.md AND tests required for submission. Missing readme document and tests will result in a best score of 2/10**
