var SubscriptionCheckout = SubscriptionCheckout || {};

const stripe = Stripe("pk_test_51OPpJqKZqzi7Rqy6YHsfwTEjCYTvzKo6Zv4VntNVxUtDckxphqoGJGOnc9W1pReo7Pdg4Xi30DbbvMHV3rYbanaI00BywDA5CY");

let plan;

let elements;

// Fetches a payment intent and captures the client secret
SubscriptionCheckout.initialise = async function (plan_id) {
    plan = { id: plan_id }

    // TODO: CONVERT THIS TO A SERVICE LAYER TO CALL IN RAZOR PAGE
    const response = await fetch("/api/payment-intent", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(plan),
    });

    const clientSecret  = (await response.json())['clientSecret'];
    const appearance = {
        theme: 'stripe',
        variables: {
            colorPrimary: '#7f5af0',
            colorBackground: '#16161a',
            colorText: '#e7e7e7',
            fontFamily: 'Inter, sans-serif',
            spacingUnit: '5px'
        }
    };

    const loader = 'auto';

    elements = stripe.elements({ appearance, clientSecret, loader });

    const addressElementOptions = {
        mode: "shipping",
        fields: {
            phone: 'always',
        },
        validation: {
            phone: {
                required: 'never',
            },
        }
    }

    const paymentElementOptions = {
        layout: {
            type: "tabs",
            defaultCollapsed: false
        },
        business: {
            name: "randBox.co"
        },
        paymentMethodOrder: ['card', 'grabpay', 'paynow']
    };

    const linkAuthenticationElement = elements.create("linkAuthentication");
    const addressElement = elements.create('address', addressElementOptions);
    const paymentElement = elements.create("payment", paymentElementOptions);

    linkAuthenticationElement.mount("#link-authentication-element");
    addressElement.mount("#address-element")
    paymentElement.mount("#payment-element");
}