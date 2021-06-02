import React from 'react';
import axios from 'axios';

class PostRequestAsyncAwait extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            itemId: null
        };
    }

    async componentDidMount() {
        // POST request using axios with async/await
        const gateway = { title: 'React POST Request Example' };
        const response = await axios.post('https://localhost:44326/gatewayclient/gateways', item);
        this.setState({ itemId: response.data });
    }

    render() {
        const { itemId } = this.state;
        return (
            <div className="card text-center m-3">
                <h5 className="card-header">POST Request with Async/Await</h5>
                <div className="card-body">
                    Returned Id: {itemId}
                </div>
            </div>
        );
    }
}

export { PostRequestAsyncAwait };