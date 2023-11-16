import React from "react";
import {BrowserRouter, Route, Switch, StaticRouter} from "react-router-dom";
import Home from "./pages/home";

const RootComponent = ({ context, location, ...rest }: any) => {
    const app = (
        <div className="app">
            <Switch>
                <Route exact path="/">
                    <Home {...rest} />
                </Route>
                <Route
                    path="*"
                    render={({ staticContext }) => {
                        if (staticContext) {
                            staticContext.statusCode = 404;
                        }                            

                        return <h1>Not Found :(</h1>;
                    }}
                />
            </Switch>
        </div>
    );

    if (typeof window === 'undefined') {
        return (
            <StaticRouter
                context={context}
                location={location}>
                {app}
            </StaticRouter>
        );
    }
    
    return <BrowserRouter>{app}</BrowserRouter>;
}

export default RootComponent