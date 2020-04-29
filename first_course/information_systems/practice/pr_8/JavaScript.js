document.getElementById('inputText').value = "asdedddd";


const freqs = (text) =>
   [...text].reduce((fs, c) =>
      fs[c] ? (fs[c] = fs[c] + 1, fs)
            : (fs[c] = 1, fs), {});

const topairs = (freqs) =>
   Object.keys(freqs).map(c => [c, freqs[c]]);


let ArraySymbolsAndIndex = topairs(freqs(document.getElementById('inputText').value));

function division(arraySymbols) {
   let sum = new Number();
   for(let i = 0; i < arraySymbols.length; i++) {
      sum += arraySymbols[i][1];
   }
   sum = sum/2;
}
division(ArraySymbolsAndIndex);


function result () {
   //division(ArraySymbolsAndIndex);
}
   // var test  =  topairs(freqs("eeeeBoy"));
   // console.log(test);
   // console.log(test[0][0]);
   // console.log(test[0][1]);
   //    (4) […]
   // ​
   // 0: Array [ "e", 4 ]
   // ​
   // 1: Array [ "B", 1 ]
   // ​
   // 2: Array [ "o", 1 ]
   // ​
   // 3: Array [ "y", 1 ]
   // ​
   // length: 4
   // ​
   // <prototype>: Array []
   // JavaScript.js:14:12
   // e JavaScript.js:15:12
   // 4

// console.log(Object.keys(a:'asd','foosss'));
// // const division = () => 
// //    ;































// const test = (text) =>
//    [...text].reduce((fs, c) =>
//    fs * fs);

// const freqs = (text) =>
//    [...text].reduce((fs, c) =>
//       fs[c] ? (fs[c] = fs[c] + 1, fs)
//             : (fs[c] = 1, fs), {});

// const topairs = (freqs) =>
//    Object.keys(freqs).map(c => [c, freqs[c]]);

// const sortps = (pairs) =>
//    pairs.sort((a, b) => a[1] > b[1]);

// const tree = (ps) =>
//    ps.length < 2
//       ? ps[0]
//          : tree(sortps([[ps.slice(0, 2), ps[0][1] + ps[1][1]]].concat(ps.slice(2))));

// const codes = (tree, pfx = "") =>
//    tree[0] instanceof Array
//       ? Object.assign(codes(tree[0][0], pfx + "0"),
//          codes(tree[0][1], pfx + "1"))
//       : {[tree[0]]: pfx};

// const getcodes = (text) =>
//    codes(tree(sortps(topairs(freqs(text)))));



