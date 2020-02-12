function factorial(n) {
    let result = 1;

    for (let i = 1; i <= n; i++) {
        result *= i;
    }

    return result;
}

function main() {
    const n = +(readLine());  

    console.log(factorial(n));
}