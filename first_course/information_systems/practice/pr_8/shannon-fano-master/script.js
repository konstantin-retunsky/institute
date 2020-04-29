

let canvas = $("#canvasTree").get(0).getContext("2d");
let ribsGap = 15;
canvas.font = "18pt Arial";
document.getElementById('canvasTree').strokeStyle = 'red';

let arr = [];

let arrey = {a:5,b:55};
let test = [...arr];

let arrClone = [];
Calculate();


function Calculate() {

    // разбиваем на частоту повторения
    let str = textValue = $("#textBox").val();
    arr = [];
    while (str.length > 0) {
        let symbol = str[0];
        let repetitionRate = str.match(new RegExp(symbol, "g") || []).length;

        arr.push({
            char: symbol,
            val:  repetitionRate
        });
        for (repetitionRate; repetitionRate > 0; repetitionRate--) {
            str = str.replace(symbol, '');
        }
    }

    getCodes(arr);
    $('#textArea').val(codingText(textValue, arr));
    $("#buttonSave").prop('disabled', false);
    canvas.clearRect(0, 0, $("#canvasTree").get(0).width, $("#canvasTree").get(0).height);

    $("#tableInfo").find("tr:gt(0)").remove();
    for (let i = 0; i < arr.length; i++) {
        $('#tableInfo').append(`<tr><td>${arr[i].char}</td><td>${arr[i].val}</td><td>${arr[i].code}</td></tr>`);
    }

    anyFunctionDo(arrClone[0], {
        x: 300,
        y: 10
    }, Math.pow(maximum(arr), 2));
    anyFunctionDo1(arrClone[0]);
    document.getElementById('canvasTree').strokeStyle = 'red';
    document.getElementById('canvasTree').fillStyle = 'red';
}

function getCodes(arr) {
    //console.log(arr);
    arrClone = [...arr];

    mySort(arrClone);
    summ(arrClone);
    for (let i = 0; i < arr.length; i++) {
        let code = '';
        let ptr = arr[i];
        while (ptr.parent) {
            code = ptr.num + code;
            ptr = ptr.parent;
        }
        arr[i].code = code;
    }
}

function mySort(_arr) {
    _arr.sort((a, b) => {
        return b.val - a.val;
    });
}

function summ(_arr) {
    let sum1 = 0;
    sum2 = 0;
    let arr1 = [],
        arr2 = [];
    for (let i = 0; i < _arr.length; i++) {
        if (sum1 <= sum2) {
            sum1 += _arr[i].val;
            arr1.push(_arr[i]);
        } else {
            sum2 += _arr[i].val;
            arr2.push(_arr[i]);
        }
    }
    if (arr1.length > 1) {
        arr1 = summ(arr1);
    }
    if (arr2.length > 1) {
        arr2 = summ(arr2);
    }
    res = {
        val: arr1[0].val + arr2[0].val,
        ch1: arr1[0],
        ch2: arr2[0]
    }

    _arr.shift();
    _arr[0] = res;
    res.ch1.num = '0';
    res.ch2.num = '1';
    res.ch1.parent = _arr[0];
    res.ch2.parent = _arr[0];

    return _arr;

}

function maximum(_arr) {
    m = 0;
    for (let i = 0; i < _arr.length; i++) {
        if (_arr[i].code.length > m)
            m = _arr[i].code.length;
    }
    return m;
}

function codingText(text, arr) {
    let str = "";
    for (let i = 0; i < text.length; i++) {
        str += arr[getIndexCon(text[i], arr)].code;
    }
    return str;
}

function getIndexCon(ch, arr) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i].char == ch) {
            return i;
        }
    }
}

function anyFunctionDo(obj, pos, n) {

    obj.pos = pos;
    let getpos = function () {
        return this.parent ? {
            x: this.pos.x + this.parent.getPos().x,
            y: this.pos.y + this.parent.getPos().y,
        } : {
            x: this.pos.x,
            y: this.pos.y,
        }
    }

    obj.getPos = getpos;

    if (!obj.ch1.char) {
        anyFunctionDo(obj.ch1, {
            x: ribsGap * n,
            y: 20
        }, n / 2);
    }
    if (!obj.ch2.char) {
        anyFunctionDo(obj.ch2, {
            x: -ribsGap * n,
            y: 50
        }, n / 2);
    }
    obj.ch1.getPos = getpos;
    obj.ch2.getPos = getpos;
    obj.ch1.pos = pos;
    obj.ch2.pos = pos;
}


function anyFunctionDo1(obj) {
    if (!obj.ch1.char) {
        anyFunctionDo1(obj.ch1);
    }
    if (!obj.ch2.char) {
        anyFunctionDo1(obj.ch2);
    }


    if (obj.ch1.ch1) {
        draw(obj.ch1.getPos(), {
            x: obj.ch1.ch1.getPos().x ,
            y: obj.ch1.ch1.getPos().y
        }, "0", obj.ch1.char);
    } else {
        if (obj.ch1.ch2) {
            draw(obj.ch1.getPos(), {
                x: obj.ch1.ch2.getPos().x,
                y: obj.ch1.ch2.getPos().y
            }, "0", obj.ch1.char);
        } else {
            draw(obj.ch1.getPos(), {
                x: obj.ch1.getPos().x + ribsGap,
                y: obj.ch1.getPos().y + 80
            }, "0", obj.ch1.char);
        }
    }
    if (obj.ch2.ch1) {
        draw(obj.ch2.getPos(), {
            x: obj.ch2.ch1.getPos().x,
            y: obj.ch2.ch1.getPos().y
        }, "1", obj.ch2.char);
    } else {
        if (obj.ch2.ch2) {
            draw(obj.ch2.getPos(), {
                x: obj.ch2.ch2.getPos().x,
                y: obj.ch2.ch2.getPos().y
            }, "1", obj.ch2.char);
        } else {
            draw(obj.ch2.getPos(), {
                x: obj.ch2.getPos().x - ribsGap,
                y: obj.ch2.getPos().y + 80
            }, "1", obj.ch2.char);
        }
    }

}

function draw(begin, end, code, char) {
    begin.x
    begin.y
    canvas.beginPath();
    canvas.moveTo(begin.x, begin.y);
    canvas.lineTo(end.x, end.y);
    canvas.stroke();
    canvas.beginPath();
    canvas.arc(begin.x, begin.y, 5, 0, 2 * Math.PI);
    canvas.fill();
    canvas.fillText(code, begin.x + (end.x - begin.x) / 2 + ((code === '1') ? -11 : 0), begin.y + (end.y - begin.y) / 2);

    if (char) {
        canvas.clearRect(end.x - 15, end.y - 15, 30, 30);
        canvas.beginPath();
        canvas.arc(end.x, end.y, 15, 0, 2 * Math.PI);
        canvas.stroke();
        canvas.fillText(char, end.x - 7, end.y + 7);
    }
}
