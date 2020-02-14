function getSecondLargest(nums) {
    // Complete the function
    nums.sort((a,b) => {
        return b-a;
    })

    let secondLargest = 0;
    let temp = nums[0];

    for (const num of nums) {
        if (num !== temp) {
            secondLargest = num;
            break;
        }
    }
    return secondLargest;
}

console.log(getSecondLargest([2,3, 6, 6, 5]));
