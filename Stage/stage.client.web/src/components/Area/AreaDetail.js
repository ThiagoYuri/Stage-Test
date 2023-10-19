import React, { Component } from 'react';
import { getData, deleteData} from '../FetchData'
import { CreateList } from '../Fragment/List/ListRoot';
import { Link } from 'react-router-dom';




export class Area extends Component {
    constructor(props) {
        super(props);
        this.state = {
            areas: {},
            loading: true
        }
    }




    componentDidMount() {
        //this.populateClientsDate();
        const result = getData("https://localhost:7271/Area/"+id)
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
            ?
            <div className='align-center'><div className="spinner-border text-primary " role="status"></div></div>
            : <CreateList datas={this.state.areas} ></CreateList>;
        return (
            <div>
                <h1 id="tabelLabel" className='align-center'>Areas</h1>
                <div className="d-flex align-items-end">
                    <div>
                        <Link to="/AdicionarArea"><button className='m-2 btn btn-success' >Criar novo processo</button></Link>
                    </div>
                </div>
                {contents}
            </div>
        );
    }


}

export default Area;
