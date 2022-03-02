const prompt = require("prompt-sync")();

const input = prompt("Input string to reverse: ");

for (let index = input.length-1; index >= 0 ; index--) {
    process.stdout.write(`${input[index]}`);
}