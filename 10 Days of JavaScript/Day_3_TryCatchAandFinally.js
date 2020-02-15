function reverseString(s) {
    try {
    let splitString = s.split(""); // let splitString = "hello".split("");
 
    let reverseArray = splitString.reverse(); // let reverseArray = ["h", "e", "l", "l", "o"].reverse();
 
    let joinArray = reverseArray.join(""); // let joinArray = ["o", "l", "l", "e", "h"].join("");
    
    console.log(joinArray);
    
    } catch (e) {
        console.log('s.split is not a function');
        console.log(s);
        
    }   
}

console.log(reverseString("1234"));
