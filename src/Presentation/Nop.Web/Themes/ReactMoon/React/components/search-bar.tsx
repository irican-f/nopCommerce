import React from "react"

const SearchBar = (props: any) => {
    console.log("SearchBar props", props)
    
    return (
        <h1>SearchBar from React</h1>
    )
}

// @ts-ignore
global.SearchBar = SearchBar;
