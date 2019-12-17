// Swapping variables
let a = 'red';
let b = 'blue';

let temp = a;
a = b;
b = temp;

console.log(a);
console.log(b);

// Max of two numbers
function max(num1, num2) {
    return (num1 > num2) ? num1 : num2
}

// Landscape or portrait
function isLandscape(width, height) {
    return (width > height);
}

// fizzbuzz
function fizzBuzz(input) {
    if (typeof input !== "number") {
        return NaN;
    }

    if (input % 5 === 0 && input % 3 === 0) {
        return "fizzbuzz";
    }

    if (input % 5 === 0) {
        return "buzz";
    }

    if (input % 3 === 0) {
        return "fizz";
    }

    return input;
}

// demerit points
console.log(checkspeed(131.7));

function checkspeed(speed) {
    let roundedSpeed = Math.floor(speed);
    let overSpeedLimit = roundedSpeed - 70;
    if (overSpeedLimit <= 4) {
        return "ok";
    } 

    let demeritPoints = Math.floor(overSpeedLimit / 5);
    if (demeritPoints < 11) {
        return "points on license: " + demeritPoints + " point(s)";
    } else {
        return "license suspended: " + demeritPoints + " point(s)";
    }
}

// even and odd numbers
showNumbers(10);

function showNumbers(limit) {
    for (let i = 0; i <= limit; i++) {
        if (i % 2 === 0) {
            console.log(i + ": EVEN");
        } else {
            console.log(i + ": ODD");
        }
    }
}

// count truthy
const array = [1, 2, 3];
console.log(countTruthy(array));

function countTruthy(array) {
    let count = 0;
    for (const elem of array) {
        if (elem) {
            ++count;
        }
    }

    return count;
}

// string properties
const movie = {
    title: "a",
    releaseYear: 2019,
    rating: 4.5,
    director: "b"
}

showProperties(movie);

function showProperties(obj) {
    for (let property in obj) {
        if (typeof obj[property] === "string") {
            console.log(property, obj[property]);
        }
    }
}

// sum of multiples of 3 and 5
console.log(sum(10));

function sum(limit) {
    let sum = 0;
    for (let i = 1; i <= limit; i++) {
        if (i % 3 === 0 || i % 5 === 0) {
            sum += i;
        } 
    }

    return sum;
}

// grade
const marks = [80, 80, 50];
console.log(calculateGrade(marks));

function calculateGrade(marks) {
    let sum = 0;
    for (let mark of marks) {
        sum += mark;
    }

    const avg = sum / marks.length;
    if (avg <= 59) {
        return "F";
    } else if (avg <= 69) {
        return "D";
    } else if (avg <= 79) {
        return "C";
    } else if (avg <= 89) {
        return "B";
    } else {
        return "A";
    }
}



