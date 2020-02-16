function getCount(objects) {
    let counter = 0;
    for (let obj of object) {
        if (obj.x === obj.y) {
            counter++;
        }
    }
    console.log(counter);
    
}
// Alternative
//return objects.filter(function(o){return o.x===o.y}).length;