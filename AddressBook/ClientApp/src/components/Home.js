import React, { useState, useEffect} from 'react';

export function Home() {

    return (<GetAddresses/>);
}


function GetAddresses() {
    const [data, setData] = useState([]);

    useEffect(() => {
        const fetchData = async () => {
            var response = await fetch('addressbook');
            var info = await response.json();
            setData(info);
        }
        fetchData();
    }, []);

    return (
        <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <td>First Name</td>
                    <td>Last Name</td>
                    <td>Street Address</td>
                    <td>City</td>
                    <td>State</td>
                    <td>Zip Code</td>
                </tr>
            </thead>
            <tbody>
                {data.map(info =>
                    <tr>
                        <td>{info.firstName}</td>
                        <td>{info.lastName}</td>
                        <td>{info.streetAddress}</td>
                        <td>{info.city}</td>
                        <td>{info.state}</td>
                        <td>{info.zipCode}</td>
                        </tr>
                    )}
            </tbody>
        </table>
        );
}
