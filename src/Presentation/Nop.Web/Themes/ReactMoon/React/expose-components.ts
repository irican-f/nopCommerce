import React from 'react';
import ReactDOM from 'react-dom';
import ReactDOMServer from 'react-dom/server';
import Helmet from 'react-helmet';
// import RootComponent from './index';

global.React = React;
global.ReactDOM = ReactDOM;
global.ReactDOMServer = ReactDOMServer;

// @ts-ignore
global.Helmet = Helmet;
// @ts-ignore
// global.Components = { RootComponent };