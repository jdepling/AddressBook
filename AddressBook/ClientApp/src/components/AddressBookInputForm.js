import React, { Component } from 'react';

export function AddressBookInputForm(props) {
    return (
        <form>
            <table>
                <tr>
                    <td><label for="fname">First name:</label></td>
                    <td><input type="text" id="fname" name="fname" /></td>
                </tr>

                <tr>
                    <td><label for="lname">Last name:</label></td>
                    <td><input type="text" id="lname" name="lname" /></td>
                </tr>

                <tr>
                    <td><label for="streetAddress">Street Address:</label></td>
                    <td><input type="text" id="streetAddress" name="streetAddress" /></td>
                </tr>

                <tr>
                    <td><label for="city">City:</label></td>
                    <td><input type="text" id="city" name="city" /></td>
                </tr>

                <tr>
                    <td><label for="state">State:</label></td>
                    <td><input type="text" id="state" name="state" /></td>
                </tr>

                <tr>
                    <td><label for="zipCode">Zip Code:</label></td>
                    <td><input type="text" id="zipCode" name="zipCode" /></td>
                </tr>
            </table>

            <input type="submit" value="Submit" />
        </form>
    );
}