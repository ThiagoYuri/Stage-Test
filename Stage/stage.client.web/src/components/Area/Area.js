import React, { Component } from 'react';
import { getData } from '../FetchData'
import { CreateList } from '../Fragment/List/ListRoot';
export class Area extends Component {
    constructor(props) {
        super(props);
        this.state = { areas: [], loading: true };
    }

    componentDidMount() {
        //this.populateClientsDate();
        const result = getData("https://localhost:7271/Area/all")
        result.then((response) => {
            try {
                console.log(response)
                this.setState({ areas: response.result, loading: response.loading })
            }
            catch (error) {
                console.log('Error: ', error);
            }
        }).catch((err) => {
            console.log('error2', err);
        });
        console.log(result)
    }

    render() {
        let contents = this.state.loading
            ? <div className="spinner-border text-primary" role="status">
                    <span className="visually-hidden">Loading...</span>
                </div>
            : <CreateList columns={["Id","Nome"]} datas={this.state.areas}></CreateList>;
        return (
            <div>
                <h1 id="tabelLabel" className='align-center'>Areas</h1>
                <div className="d-flex align-items-end">
                    <div><button className='m-2 btn btn-success'>Criar nova Area</button></div>
                </div>
                {contents}
            </div>
        );
    }


}

export default Area;
