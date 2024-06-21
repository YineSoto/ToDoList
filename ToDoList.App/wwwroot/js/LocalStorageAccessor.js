export function get(key){
    return window.localStorage.getItem(key);
}

export function set(key, value){
    return window.localStorage.setItem(key, value);
}

export function clear(){
    window.localStorage.clear();
}

export function remove(key){
    window.localStorage.removeItem(key);
}
