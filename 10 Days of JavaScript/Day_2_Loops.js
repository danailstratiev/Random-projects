/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
    let vowelsInS = [];
    let consonantsInS = [];
    let vowels = 'aeiou';
    for (const letter of s) {
        if (vowels.includes(letter)) {
            vowelsInS.push(letter);
        }else{
            consonantsInS.push(letter);
        }    
    }

    for (const vowel of vowelsInS) {
        console.log(vowel);        
    }
    for (const consonant of consonantsInS) {
        console.log(consonant);        
    }
}

vowelsAndConsonants('ashdfah');