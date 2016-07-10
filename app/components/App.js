import React, { Component } from 'react';

export default class App extends Component {
    render() {
        let content;

        content = (<h1>Hello World</h1>);

        return (
            <div>
                {content}
            </div>
        );
    }
}
