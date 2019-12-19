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

// stars
showStars(10);

function showStars(rows) {
    let s = "";
    while (rows > 0) {
        s += "*";
        console.log(s);
        --rows;
    }
}

// prime numbers
showPrimes(20);

function showPrimes(limit) {
    for (let i = 2; i <= limit; i++) {
        let j = i - 1;
        let isPrime = true;
        while (j > 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
            --j;
        }

        if (isPrime) {
            console.log(i)
        }
    }
}

// address object
let address = {
    street: "Foo Ave",
    city: "Bar City",
    zipCode: "011010"
};
showAddress(address);

function showAddress(obj) {
    for (let property in obj) {
        console.log(property, obj[property]);
    }
}

// factory and constructor functions
function createAddress(street, city, zipCode){
    return {
        street,
        city,
        zipCode
    };
}

function Address(street, city, zipCode) {
    this.street = street,
    this.city = city,
    this.zipCode = zipCode
}

let address1 = new Address("foo st.", "bar city", "11111");
let address2 = new Address("foo st.", "bar city", "11111");

// object equality
function areEqual(address1, address2) {
    return address1.street === address2.street && address1.city === address2.city && address1.zipCode === address2.zipCode;
}

function areSame(address1, address2) {
    return (address1 === address2);
}

console.log(areEqual(address1, address2));

// blog post object
let blogPost = {
    title: "Foo",
    body: "Bar",
    author: "Baz",
    views: 10,
    comments: [
        {
            author: "Cat",
            body: "Dog"
        },
        {
            author: "Eel",
            body: "Fog"
        }
    ],
    isLive: true
};

console.log(blogPost);

// constructor functions
function Post(title, body, author) {
    this.title = title;
    this.body = body;
    this.author = author;
    this.views = 0;
    this.comments = [];
    this.isLive = false;
}

let post1 = new Post("a", "b", "c");
console.log(post1);

// price range object
let priceRanges = [
    { label: "$", tooltip: "Inexpensive", minPerPerson: 0, maxPerPerson: 10},
    { label: "$$", tooltip: "Moderate", minPerPerson: 11, maxPerPerson: 20},
    { label: "$$$", tooltip: "Expensive", minPerPerson: 21, maxPerPerson: 50},
];

