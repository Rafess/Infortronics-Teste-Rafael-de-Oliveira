// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const paragraph = document.querySelector(".sorted-numbers");
const saveToFileBtn = document.querySelector(".save-file");

function sortNumbers() {
    paragraph.textContent = "";
    let input = document.querySelector("#numbers").value;
    let numbers = input.split(" ");
    let sortedNumbers = numbers.sort((a, b) => a - b);
    paragraph.append(sortedNumbers);
}


const perfecParagraph = document.querySelector(".perfect-numbers");

function isPerfect() {
    let sumDivisors = 0;
    const userNumber = parseInt(document.querySelector("#perfect").value);
    for (let i = 1; i <= (userNumber / 2); i += 1) {
        if (userNumber % i === 0) {
            sumDivisors += i;
        }
    }
    if (userNumber === sumDivisors) {
        perfecParagraph.textContent = `${userNumber} é perfeito!`
    } else {
        perfecParagraph.textContent = `${userNumber} não é perfeito!`
    }

}

const tableParagraph = document.querySelector(".table-numbers");
function calcTable() {
    const userTableNumber = parseInt(document.querySelector("#table").value);
    let table = [];
    for (let i = 1; i <= 10; i += 1) {
        table = [...table, `${userTableNumber} X ${i} = ${(userTableNumber * i)}`]
    }
    tableParagraph.innerHTML = table.join("<br>")

}
